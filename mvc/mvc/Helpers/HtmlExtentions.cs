using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Helpers
{
    public static class HtmlExtentions
    {
        public static MvcHtmlString SuccessButton(this HtmlHelper helper, string innerText, string path)
        {
            TagBuilder builder = new TagBuilder("a");
            builder.AddCssClass("btn btn-success");
            builder.MergeAttribute("href", path);
            builder.InnerHtml = innerText;
            return new MvcHtmlString(builder.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString Image(this HtmlHelper helper, string imageUrl, string alt = "", string width = "auto", string height = "auto")
        {
            TagBuilder builder = new TagBuilder("img");
            builder.AddCssClass("img");
            builder.MergeAttribute("src", imageUrl);
            builder.MergeAttribute("alt", alt);
            builder.MergeAttribute("width", String.IsNullOrEmpty(width) ? "auto" : $"{width}px");
            builder.MergeAttribute("height", String.IsNullOrEmpty(height) ? "auto" : $"{height}px");
            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
        public static MvcHtmlString YouTubeEmbedder(this HtmlHelper helper, string videoId, int width = 560, int height = 315)
        {
            TagBuilder builder = new TagBuilder("iframe");
            builder.MergeAttribute("src", @"https://www.youtube.com/embed/" + videoId);
            builder.MergeAttribute("frameborder", "0");
            builder.MergeAttribute("allowfullscreen", null);
            builder.MergeAttribute("width", $"{width}px");
            builder.MergeAttribute("height", $"{height}px");
            return new MvcHtmlString(builder.ToString(TagRenderMode.Normal));
        }
    }
}