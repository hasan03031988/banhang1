using AutoMapper;
using BanHang.Model.Models;
using BanHang.Service;
using BanHang.Web.Infrastructure.Core;
using BanHang.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BanHang.Web.Infrastructure.Extensions;

namespace BanHang.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage repuest)
        {
            return CreateHttpResponse(repuest, () =>
            {


                var listCategory = _postCategoryService.GetAll();
                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);

                HttpResponseMessage response = repuest.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);

                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage repuest, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(repuest, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    repuest.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory newPostCategory = new PostCategory();
                    newPostCategory.UpdatePostCategory(postCategoryVm);
                    var category = _postCategoryService.Add(newPostCategory);
                    _postCategoryService.Save();
                    response = repuest.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage repuest, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(repuest, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    repuest.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);
                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();
                    response = repuest.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage repuest, int id)
        {
            return CreateHttpResponse(repuest, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    repuest.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();
                    response = repuest.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

    }
}