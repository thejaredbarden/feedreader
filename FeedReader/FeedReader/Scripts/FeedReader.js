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

    $("#article_1").on("click", function () {
        alert("click");
        $.ajax({
            url: "/Feed/GetArticleContent",
            data: { articleId: $(this).attr("id") },
            succes: function (view) {
                $("#articlecontent").html(view);
                $("#articlecontent").slideToggle(500);
            },
            error: function () {
                $("#articlecontent").html("You done did broked it.");

            }
        });
    });
});