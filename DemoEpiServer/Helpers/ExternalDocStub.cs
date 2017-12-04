using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoEpiServer.Helpers
{
   

    public class Author
    {
        public string UserName { get; set; }
    }

    public class Tag
    {
        public string TagType { get; set; }
        public string NativeTagValue { get; set; }
        public List<string> TagValues { get; set; }
    }

    public class BBCurated
    {
        public int BBcuratedById { get; set; }
        public bool IsBBCurated { get; set; }
    }

    public class Asset
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public int AssetType { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public Author Author { get; set; }
        public DateTime CreationDate { get; set; }
        public string URL { get; set; }
        public bool IsPreviewURLUpdated { get; set; }
        public string PreviewURL { get; set; }
        public string AssetGroup { get; set; }
        public bool IsParent { get; set; }
        public object ParentId { get; set; }
        public List<Tag> Tags { get; set; }
        public string Quote { get; set; }
        public string Description { get; set; }
        public BBCurated BBCurated { get; set; }
        public bool IsDeleted { get; set; }
        public int NumberOfLikes { get; set; }
        public bool IsLikedByUser { get; set; }
        public int NumberOfViews { get; set; }
        public string DisplayImageUrl { get; set; }
        public bool IsDisplayImageUrlUpdated { get; set; }
        public bool IsDefaultDisplayImage { get; set; }
        public bool IsErrorUploadingDisplayImage { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string SystemUpdatedBy { get; set; }
    }

    public class DynamicFilter
    {
        public string TagType { get; set; }
        public object NativeTagValue { get; set; }
        public List<string> TagValues { get; set; }
    }

    public class ExternalDocStub
    {
        public List<Asset> Assets { get; set; }
        public bool Success { get; set; }
        public object ErrorCode { get; set; }
        public string Message { get; set; }
        public object MiscellaneousText { get; set; }
        public List<DynamicFilter> DynamicFilters { get; set; }
    }
}