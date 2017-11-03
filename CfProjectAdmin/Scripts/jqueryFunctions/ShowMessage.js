
function showMessage(message) {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                return true;
            }
        }
    };

    var box = bootbox.dialog({
        size: 'medium',
        title: "Info",
        message: message,
        buttons: button
    });
}