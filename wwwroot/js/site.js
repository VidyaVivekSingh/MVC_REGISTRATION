// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $("#Reference").change(function () {
        $("#textarea").val($(this).val());
        if ($(this).val() === "Others") {
            $("#textarea").val('');
            $("#PleaseSpecify").show();
        } else {
            $("#PleaseSpecify").hide();
        }
    });
});