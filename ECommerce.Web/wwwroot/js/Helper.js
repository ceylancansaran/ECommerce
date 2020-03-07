var Helper = {
    Module: {
        Init: function(name){
            $.ajax({
                ModuleName: name,
                type: "GET",
                url: "/module/" + name,
                data: [],
                success: Helper.Module.Init_CallBack,
                dataType: "html",
                contentType: "html"
            });
        },
        Init_CallBack: function (result) {
            $("#Module-" + this.ModuleName).html(result);
        }
    }
};