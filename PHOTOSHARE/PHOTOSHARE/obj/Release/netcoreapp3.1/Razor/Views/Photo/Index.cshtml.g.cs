#pragma checksum "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c24188848bf49a4d5dde2bd898df9bab7489ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_Index), @"mvc.1.0.view", @"/Views/Photo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c24188848bf49a4d5dde2bd898df9bab7489ee", @"/Views/Photo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1f88fa0843f5c74b36eca495447da66d4f638f", @"/Views/_ViewImports.cshtml")]
    public class Views_Photo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhotoViewModel>
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
#line 3 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
   
    ViewData["Title"] = "Photos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button id=\"btnAddphoto\" class=\"btn btn-primary\">Add photo</button>\r\n<br />\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 169, "\"", 213, 1);
#nullable restore
#line 10 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
WriteAttributeValue("", 177, Url.Action("CreatePhoto", "Photo" ), 177, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"createPhotoUrl\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 259, "\"", 301, 1);
#nullable restore
#line 11 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
WriteAttributeValue("", 267, Url.Action("EditPhoto", "Photo" ), 267, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"editPhotoUrl\" />\r\n\r\n");
#nullable restore
#line 13 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
Write(Html.HiddenFor(x => x.AlbumId, new { id="albumId" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"my-4 row\">\r\n");
#nullable restore
#line 15 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
     if (Model.Photos.Any())
    {
        foreach (var photo in Model.Photos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 m-4 py-3 photo-container justify-content-center\">\r\n                <a class=\"p-3\">");
#nullable restore
#line 20 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
                          Write(photo.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 652, "\"", 670, 1);
#nullable restore
#line 21 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
WriteAttributeValue("", 658, photo.Image, 658, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded p-2\">\r\n                <div class=\"row justify-content-around p-2 actionButtons\">\r\n                    <a id=\"edit\"\r\n                       class=\"btn btn-light btn-sm\"\r\n                       data-id=\"");
#nullable restore
#line 25 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
                           Write(photo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i class=\"bi bi-pencil\"></i> Edit\r\n                    </a>\r\n                    <a id=\"view\" class=\"btn btn-light btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1058, "\"", 1077, 1);
#nullable restore
#line 28 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
WriteAttributeValue("", 1065, photo.Image, 1065, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-eye-fill\"></i> Download</a>\r\n                    <a id=\"delete\"\r\n                       class=\"btn btn-light btn-sm\"\r\n                       data-url=\"");
#nullable restore
#line 31 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
                            Write(Url.Action("Deletephoto","Photo",new { id=@photo.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i class=\"bi bi-trash\"></i> Delete\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary my-4\" role=\"alert\">\r\n            You have no photos!\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\PHOTOSHARE\CMPG323-PROJECT2\PHOTOSHARE\PHOTOSHARE\Views\Photo\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

    <div class=""modal"" role=""dialog"" id=""createPhotoModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Create new Photo</h5>
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

    <div class=""modal"" role=""dialog"" id=""deletePhotoModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-cont");
            WriteLiteral(@"ent"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Delete Photo</h5>
                </div>
                <div class=""modal-body"">
                    Are you Sure you want to delete the Photo?
                </div>
                <div class=""modal-footer"">
                    <button id=""deletePhoto"" type=""button"" class=""btn btn-primary"">Yes</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
                </div>
            </div>
        </div>
    </div>

    <div id=""snackbar"" class=""snackbar""></div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c24188848bf49a4d5dde2bd898df9bab7489ee10263", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c24188848bf49a4d5dde2bd898df9bab7489ee11307", async() => {
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
            $('#edit').on('click', function () {
                debugger;
                let url = $('#editPhotoUrl').val();
                let PhotoId = $(this).data('id');
                $.get(url, { PhotoId }, function (response) {
                    $('.modal-body').html(response);
                    $('#createPhotoModal').modal('show');
                })
            })

            $('#btnAddphoto').on('click', function () {
                debugger;
                var url = $('#createPhotoUrl').val();
                $.get(url, function (response) {
                    $('.modal-body').html(response)");
            WriteLiteral(@";
                    $('#createPhotoModal').modal('show');
                });
            });

            $('#submit').on('click', () => {
                debugger;
                var reader = new FileReader();
                var file = document.querySelector('input[type=file]').files[0];;

                if (file) {
                    reader.readAsDataURL(file);
                }
                else {
                    var PhotoId = $('#Photo_Id').val();
                    if (PhotoId > 0)
                        EditPhoto(null, PhotoId);
                }

                reader.onload = function (e) {
                    var image = reader.result;
                    debugger;
                    var PhotoId = $('#Photo_Id').val();
                    if (PhotoId > 0)
                        EditPhoto(image, PhotoId);
                    else
                        CreatePhoto(image);
                };
            });

            $('#delete').on('click', function");
            WriteLiteral(@" () {
                let url = $('#delete').data('url');
                $('#deletePhotoModal').modal('show');
                $('#deletePhotoModal #deletePhoto').attr('data-url', url);
                document.getElementById('deletePhoto').addEventListener('click', function (event) {
                    debugger;
                    const { url } = event.currentTarget.dataset;
                    $.post(url, function () {
                        $('#deletePhotoModal').modal('hide');
                        showToastr('Photo Deleted!');
                        window.location.reload();
                    }).fail(function () {
                        showToastr('Photo cannot be Deleted!');
                    })
                })
            });

        })

        function EditPhoto(image, id) {
            var url = $('#createPhotoModal #url').val();
            var title = $('#title').val();
            image = image ?? '';

            $.post(url, { title, image, id }, function ");
            WriteLiteral(@"() {
                debugger;
                $('#createPhotoModal').modal('hide');
                $('.modal-body').html();
                showToastr('Photo Updated!');
                window.location.reload();
            });
        }

        function CreatePhoto(image, albumId) {
            var url = $('#createPhotoModal #url').val();
            var title = $('#title').val();
            var albumId = $('#albumId').val();
            $.post(url, { title, albumId, image }, function () {
                debugger;
                $('#createPhotoModal').modal('hide');
                $('.modal-body').html();
                showToastr('Photo Created!');
                window.location.reload();
            });
        }

        function showToastr(text) {
            toastr['success'](text);

            toastr.options = {
                'newestOnTop': false,
                'progressBar': false,
                'positionClass': 'toast-top-right',
                'preventDu");
            WriteLiteral(@"plicates': false,
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

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhotoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
