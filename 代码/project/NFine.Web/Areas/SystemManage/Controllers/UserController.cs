
using BlueGene.Application.SystemManage;
using BlueGene.Code;
using BlueGene.Domain.Entity.BusinessManage;
using BlueGene.Domain.Entity.SystemManage;
using BlueGene.Application.BusinessManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace BlueGene.Web.Areas.SystemManage.Controllers
{
    public class UserController : ControllerBase
    {
        private UserApp userApp = new UserApp();
        private UserLogOnApp userLogOnApp = new UserLogOnApp();

        private ProjectsApp projectsApp = new ProjectsApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = userApp.GetList(pagination, keyword),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = userApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(UserEntity userEntity, UserLogOnEntity userLogOnEntity, string keyValue,object[] F_ProjectsId,string ProjectsId)
        {
            if (F_ProjectsId!=null)
            {
                userEntity.F_ProjectsId = Common.ConvertToDivisionStr(F_ProjectsId, ",");
            }
            else
            {
                userEntity.F_ProjectsId = ProjectsId;
            }
            userApp.SubmitForm(userEntity, userLogOnEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            userApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }
        [HttpGet]
        public ActionResult RevisePassword()
        {
            return View();
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitRevisePassword(string userPassword, string keyValue)
        {
            userLogOnApp.RevisePassword(userPassword, keyValue);
            return Success("重置密码成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DisabledAccount(string keyValue)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.F_Id = keyValue;
            userEntity.F_EnabledMark = false;
            userApp.UpdateForm(userEntity);
            return Success("账户禁用成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult EnabledAccount(string keyValue)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.F_Id = keyValue;
            userEntity.F_EnabledMark = true;
            userApp.UpdateForm(userEntity);
            return Success("账户启用成功。");
        }

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetProjectsTreeSelectJson()
        {

            var data = projectsApp.GetList();
           
            var treeList = new List<TreeViewModel>();
            foreach (ProjectsEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                tree.id = item.F_Id;
                tree.text = item.F_ProjectName;
                tree.value = item.F_Id;
                tree.parentId = "0";
                tree.isexpand = true;
                tree.complete = true;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
        }


    }
}
