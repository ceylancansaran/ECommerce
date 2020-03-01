var Home_Index = {
    Init: function () {
        $.ajax({
            type: "GET",
            url: "/module/userbar",
            data: [],
            success: Home_Index.ModuleUserBar_CallBack,
            dataType: "html",
            contentType: "html"
        });
    },
    ModuleUserBar_CallBack: function (result) {
        $("#Module-UserBar").html(result);
    }
};