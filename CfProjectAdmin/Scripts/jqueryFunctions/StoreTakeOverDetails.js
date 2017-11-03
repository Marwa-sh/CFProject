$(document).ready(function () {
    $(document).on('click', '#storeTakeOverDetails', function () {
        $('body').addClass('wait');
        url = $(this).attr('ajax-url');
        redirectUrl = $(this).attr('redirect-url');
        $.ajax({
            url: $(this).attr('ajax-url'),
            type: "POST",
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                $.msgBox({
                    type: "success",
                    title: 'Take Over Details',
                    content: data.message,
                    opacity: 0.5,
                    buttons: [{ value: "OK" }],
                    success: function (result) {
                        location.href = redirectUrl;
                    }
                })
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });
    });
});
