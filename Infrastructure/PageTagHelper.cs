using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-blah")]
    public class PageTagHelper : TagHelper
    {

    }
}
