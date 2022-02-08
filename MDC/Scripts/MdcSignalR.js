$(function () {
    // Reference the auto-generated proxy for the hub.
    var progress = $.connection.progressHub;
    console.log(progress);
    alert("progress")

    // Create a function that the hub can call back to display messages.
    progress.client.AddProgress = function (message, percentage) {
        ProgressBarModal("show", message + " " + percentage);
        //alert(message);
        $('#ProgressMessage').width(percentage);
        if (percentage == "100%") {
            ProgressBarModal();
        }
    };

    $.connection.hub.start().done(function () {
        var connectionId = $.connection.hub.id;
        console.log(connectionId);
    });

});


function ProgressBarModal(showHide) {

    if (showHide === 'show') {
        $('#mod-progress').modal('show');
        if (arguments.length >= 2) {
            $('#progressBarParagraph').text(arguments[1]);
        } else {
            $('#progressBarParagraph').text('U tijeku...');
        }

        window.progressBarActive = true;

    } else {
        $('#mod-progress').modal('hide');
        window.progressBarActive = false;
    }
}