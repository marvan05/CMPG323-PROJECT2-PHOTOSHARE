#pragma checksum "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30fce30ec1d2f061e200d14d674be5b119d6498a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_Index), @"mvc.1.0.view", @"/Views/Album/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\_ViewImports.cshtml"
using PHOTOSHARE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\_ViewImports.cshtml"
using PHOTOSHARE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30fce30ec1d2f061e200d14d674be5b119d6498a", @"/Views/Album/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1f88fa0843f5c74b36eca495447da66d4f638f", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlbumViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
  
    ViewData["Title"] = "Albums";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""./css/Album.css"">
<link rel=""stylesheet"" href=""./lib/bootstrap/dist/css/bootstrap.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.css""
      integrity=""sha512-3pIirOrwegjM6erE5gPSwkUzO+3cTjpnV9lexlNZqvupR64iZBnOOTiiLPb9M36zpMScbmUNIcHUqKD47M719g==""
      crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.1/font/bootstrap-icons.css"">

<h1>Albums</h1>

<button id=""btnAddAlbum"" class=""btn btn-primary"">Add Album</button>
<br />

<input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 692, "\"", 735, 1);
#nullable restore
#line 19 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 700, Url.Action("CreateAlbum", "Album"), 700, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"createAlbumUrl\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 781, "\"", 824, 1);
#nullable restore
#line 20 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 789, Url.Action("DeleteAlbum", "Album"), 789, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"deleteAlbumUrl\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 870, "\"", 911, 1);
#nullable restore
#line 21 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 878, Url.Action("EditAlbum", "Album"), 878, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"editAlbumUrl\" />\r\n\r\n<div class=\"my-4 row\">\r\n");
#nullable restore
#line 24 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
     if (Model.MyAlbums.Any())
    {
        foreach (var album in Model.MyAlbums)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 m-4 py-3 photo-container\">\r\n                <a class=\"p-3\">");
#nullable restore
#line 29 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
                          Write(album.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1188, "\"", 1206, 1);
#nullable restore
#line 30 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 1194, album.Image, 1194, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded p-2\"");
            BeginWriteAttribute("alt", " alt=\"", 1237, "\"", 1255, 1);
#nullable restore
#line 30 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 1243, album.Owner, 1243, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row justify-content-between p-2 actionButtons\">\r\n                    <a id=\"edit\"\r\n                       class=\"btn btn-light btn-sm\"\r\n                       data-id=\"");
#nullable restore
#line 34 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
                           Write(album.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i class=\"bi bi-pencil\"></i> Edit\r\n                    </a>\r\n                    <a id=\"view\" class=\"btn btn-light btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1614, "\"", 1678, 1);
#nullable restore
#line 37 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 1621, Url.Action("Index", "Photo", new { albumId = album.Id }), 1621, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-eye-fill\"></i> View</a>\r\n                    <a id=\"delete\"\r\n                       class=\"btn btn-light btn-sm\"\r\n                       data-url=\"");
#nullable restore
#line 40 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
                            Write(Url.Action("DeleteAlbum", "Album", new { id = @album.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i class=\"bi bi-trash\"></i> Delete\r\n                    </a>\r\n                    <a id=\"share\" class=\"btn btn-light btn-sm\" data-id=\"");
#nullable restore
#line 43 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
                                                                   Write(album.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"bi bi-share\"></i> Share</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 46 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
        }

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            You have no Albums!\r\n        </div>\r\n");
#nullable restore
#line 54 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<h1>Shared With Me</h1>\r\n\r\n<div class=\"my-4 row\">\r\n");
#nullable restore
#line 61 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
     if (Model.SharedAlbums.Any())
    {
        foreach (var album in Model.SharedAlbums)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 m-4 py-3 photo-container\">\r\n                <a class=\"p-3\">");
#nullable restore
#line 66 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
                          Write(album.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2605, "\"", 2623, 1);
#nullable restore
#line 67 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 2611, album.Image, 2611, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded p-2\"");
            BeginWriteAttribute("alt", " alt=\"", 2654, "\"", 2672, 1);
#nullable restore
#line 67 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 2660, album.Owner, 2660, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row justify-content-between p-2 actionButtons\">\r\n                    <a id=\"view\" class=\"btn btn-light btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 2814, "\"", 2878, 1);
#nullable restore
#line 69 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
WriteAttributeValue("", 2821, Url.Action("Index", "Photo", new { albumId = album.Id }), 2821, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-eye-fill\"></i> View</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 72 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
        }

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary my-4\" role=\"alert\">\r\n            No Albums shared with you!\r\n        </div>\r\n");
#nullable restore
#line 80 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<br />

<div class=""modal"" role=""dialog"" id=""createAlbumModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Create new Album</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""submit"">Save</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" role=""dialog"" id=""deleteAlbumModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""mo");
            WriteLiteral(@"dal-title"">Delete Album</h5>
            </div>
            <div class=""modal-body"">
                Are you Sure you want to delete the album?
            </div>
            <div class=""modal-footer"">
                <button id=""deleteAlbum"" type=""button"" class=""btn btn-primary"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" role=""dialog"" id=""shareAlbumModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Share Album</h5>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""username"">Share With User</label>
                    <input data-url=""");
#nullable restore
#line 130 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Album\Index.cshtml"
                                Write(Url.Action("ShareAlbum", "Album"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" type=""text"" id=""username"" class=""form-control"" required />
                </div>
            </div>
            <div class=""modal-footer"">
                <button id=""shareAlbum"" type=""button"" class=""btn btn-primary"">Share</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
            </div>
        </div>
    </div>
</div>

<div id=""snackbar"" class=""snackbar""></div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fce30ec1d2f061e200d14d674be5b119d6498a15466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30fce30ec1d2f061e200d14d674be5b119d6498a16506", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js""
        integrity=""sha512-VEd+nq25CkR676O+pLBnDW09R7VQX9Mdiij052gVCp5yVH3jGtH70Ho/UUv4mJDsEdTvqRCFZg0NKGiojGnUCw==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        debugger;

        $('#share').on('click', function () {
            $('#shareAlbumModal').modal('show');
            $('#username').attr('data-id', $('#share').data('id'));
            $('#shareAlbum').on('click', function () {
                debugger;
                var username = $('#username').val();
                var url = $('#username').data('url');
                var albumId = $('#username').data('id');
                $.post(url, { albumId, username }, function (response) {
                    if (response === 200)
                        showToastr('Album Shared!', false);
                    else
                        showToastr('A");
            WriteLiteral(@"lbum could not share! Ensure Username is entered correctly.', true);
                    $('#shareAlbumModal').modal('hide');
                });
            });
        });

        $('#edit').on('click', function () {
            debugger;
            let url = $('#editAlbumUrl').val();
            let albumId = $(this).data('id');
            $.get(url, { albumId }, function (response) {
                $('.modal-body').html(response);
                $('#createAlbumModal').modal('show');
            })
        })

        $('#btnAddAlbum').on('click', function () {
            var url = $('#createAlbumUrl').val();
            $.get(url, function (response) {
                $('.modal-body').html(response);
                $('#createAlbumModal').modal('show');
            });
        });

        $('#submit').on('click', () => {
            var reader = new FileReader();
            var file = document.querySelector('input[type=file]').files[0];;

            if (file) {
      ");
            WriteLiteral(@"          reader.readAsDataURL(file);
            }
            else {
                var albumId = $('#Album_Id').val();
                if (albumId > 0)
                    EditAlbum(null, albumId);
            }

            reader.onload = function (e) {
                var image = reader.result;
                var albumId = $('#Album_Id').val();
                if (albumId > 0)
                    EditAlbum(image, albumId);
                else
                    CreateAlbum(image);
            };
        });

        $('#delete').on('click', function () {
            let url = $('#delete').data('url');
            $('#deleteAlbumModal').modal('show');
            $('#deleteAlbumModal #deleteAlbum').attr('data-url', url);
            document.getElementById('deleteAlbum').addEventListener('click', function (event) {
                const { url } = event.currentTarget.dataset;
                $.post(url, function () {
                    $('#deleteAlbumModal').modal('hide');
 ");
            WriteLiteral(@"                   showToastr('Album Deleted!', false);
                    window.location.reload();
                }).fail(function () {
                    showToastr('Album cannot be Deleted!', true);
                })
            })
        });

    })

    function EditAlbum(image, id) {
        var url = $('#createAlbumModal #url').val();
        var title = $('#title').val();
        image = image ?? '';

        $.post(url, { title, image, id }, function () {
            $('#createAlbumModal').modal('hide');
            $('.modal-body').html();
            showToastr('Album Updated!', false);
            window.location.reload();
        });
    }

    function CreateAlbum(image) {
        var url = $('#createAlbumModal #url').val();
        var title = $('#title').val();

        $.post(url, { title, image }, function () {
            $('#createAlbumModal').modal('hide');
            $('.modal-body').html();
            showToastr('Album Created!', false);
          ");
            WriteLiteral(@"  window.location.reload();
        });
    }

    function showToastr(text, fail) {
        if (!fail)
            toastr['success'](text);
        else
            toastr['error'](text);

        toastr.options = {
            'newestOnTop': false,
            'progressBar': false,
            'positionClass': 'toast-top-right',
            'preventDuplicates': false,
            'showDuration': '300',
            'hideDuration': '1000',
            'timeOut': '5000',
            'extendedTimeOut': '1000',
            'showEasing': 'swing',
            'hideEasing': 'linear',
            'showMethod': 'fadeIn',
            'hideMethod': 'fadeOut'
        };
    }

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlbumViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
