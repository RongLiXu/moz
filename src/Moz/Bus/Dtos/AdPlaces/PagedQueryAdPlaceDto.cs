﻿using FluentValidation.Attributes;
using Moz.Bus.Services.Localization;
using Moz.Validation;

namespace Moz.Bus.Dtos.AdPlaces
{
    /// <summary>
    /// tab_ad_place
    /// </summary>
    [Validator(typeof(PagedQueryAdPlaceRequestValidator))]
    public class PagedQueryAdPlaceRequest
    {
        #region 属性
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string Keyword{ get;set; }
        #endregion     
    }
    
    
    public class PagedQueryAdPlaceResponse: PagedList<QueryAdPlaceItem>
    {
    
    }
    
    public class QueryAdPlaceItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get;set; } 
        /// <summary>
        /// 
        /// </summary>
        public string Title { get;set; } 
        /// <summary>
        /// 
        /// </summary>
        public string Code { get;set; } 
        /// <summary>
        /// 
        /// </summary>
        public string Desc { get;set; } 
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime Addtime { get;set; }

        public string AddtimeString => Addtime.ToString("yyyy-MM-dd");
    }
    
    public class PagedQueryAdPlaceRequestValidator : MozValidator<PagedQueryAdPlaceRequest>
    {
        public PagedQueryAdPlaceRequestValidator(ILocalizationService localizationService)
        {
            
        }
    }
    
}
