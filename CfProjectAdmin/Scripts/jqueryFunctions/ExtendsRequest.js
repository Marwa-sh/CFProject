$(document).ready(function () {

    $().loadMore({
        button: $("#load-more"),
        container: $("#extends-requests-container"),
        auto: false,
        url: $("#load-more").attr('url'),
    });

    $('[data-toggle="delete-confirmation"]').confirmation({
        container: 'body',
        onConfirm: function () {
            //ajax call
            $('body').addClass('wait');
            $.ajax({
                type: "POST",
                url: $(this).attr('ajax-url'),
                dataType: 'json',
                cache: false,
                async: true,
                success: function (data) {
                    if (data.Status && data.Url != null) {
                        location.href = data.Url;
                    }
                    if (!data.Status) {
                        $.msgBox({
                            title: 'Approve Extending Request',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                location.reload();
                            }
                        })
                    }
                },
                error: function (data) {
                    //$.msg
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }
    });
});