using BlueGene.Code;
using BlueGene.Domain.Entity.BusinessManage;
using BlueGene.Application.BusinessManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueGene.Web.Areas.SystemManage.Controllers
{
    public class DomainController : ControllerBase
    {
        //
        // GET: /SystemManage/Domain/
        private ProjectsApp projectsApp = new ProjectsApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = projectsApp.GetList(pagination, keyword),
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
            var data = projectsApp.GetForm(keyValue);
            return Content(data.ToJson());
        }


        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ProjectsEntity projectsEntity, string keyValue)
        {
            projectsEntity.F_IsComplete = false;
            projectsApp.SubmitForm(projectsEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            projectsApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }


        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult GetProjectsDic(string keyWord)
        {
            var data = projectsApp.GetList().ToList();
            if (!string.IsNullOrEmpty(keyWord))
            {
                data = data.Where(e => e.F_ProjectName.Contains(keyWord)).ToList();
            }

            var result = new
            {
                dic = data.ToDictionary(key => key.F_Id, value => value.F_ProjectName)
            };

            return Content(result.ToJson());
        }


        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetProjectsTreeSelectJson()
        {

            var data = projectsApp.GetList();
            var LoginInfo = OperatorProvider.Provider.GetCurrent();
            if (!LoginInfo.IsSystem)
            {
                List<string> proidList = LoginInfo.ProjectsId.Split(',').ToList();
                data = data.Where(t => proidList.Contains(t.F_Id)).ToList();
            }
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

