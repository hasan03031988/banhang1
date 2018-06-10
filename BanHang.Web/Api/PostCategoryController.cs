using BanHang.Model.Models;
using BanHang.Service;
using BanHang.Web.Infrastructure.Core;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanHang.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService,IPostCategoryService postCategoryService) : 
            base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage repuest)
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
                    var listCategory = _postCategoryService.GetAll();
                    _postCategoryService.Save();
                    response = repuest.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage repuest, PostCategory postCategory)
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
                    var category = _postCategoryService.Add(postCategory);
                    _postCategoryService.Save();
                    response = repuest.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage repuest, PostCategory postCategory)
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
                    _postCategoryService.Update(postCategory);
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