$(document).ready(function () {

    $("#NPR").on("click", function () {
        $.ajax({
            url: "/Feed/GetTitles",
            data:{source: "NPR"},
            success: function (view) {
                $("#feedItems").html(view);
            },
            error: function () {
                $("#feedItems").html("Error!");
            }
        });
    });

    $("#dZone").on("click", function () {
        $.ajax({
            url: "/Feed/GetTitles",
            data: { source: "dZone" },
            success: function (view) {
                $("#feedItems").html(view);
            },
            error: function () {
                $("#feedItems").html("Error!");
            }
        });
    });
});