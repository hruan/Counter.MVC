var refreshCount = function() {
    var opts = {
        url: counterPath,
        crossDomain: true,
    };

    $.ajax(opts)
        .done(function(x) {
        $("#count").html(x);
    });
}

var vote = function(vote) {
    var opts = {
        url: counterPath,
        method: "POST",
        contentType: "application/json",
        accept: "application/json",
        crossDomain: true,
        data: JSON.stringify(vote),
        success: function() {
            console.log("refreshing");
            refreshCount();
        }
    };

    $.ajax(opts);
}

$(document).ready(function() {
    refreshCount();

    $("#upvote").click(function() {
        vote("upvote");
        console.log("upvoted!");
    });

    $("#downvote").click(function() {
        vote("downvote");
        console.log("downvoted :(");
    });
});