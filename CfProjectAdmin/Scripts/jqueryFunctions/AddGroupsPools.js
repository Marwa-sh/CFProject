$(document).ready(function () {

    $(document).on('click', '#btnAdd', function (e) {
        var group_id = $("#group_id").val();        
        var selectedPool = $("#selPool").val();        
        if (selectedPool == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select pool",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: "/Group/addSelectedGroupToPool",
                data: { group: group_id, pool: selectedPool },
                type: "GET",
                dataType: "json",
                success: function (data) {
                    if (data.status) {
                        $.msgBox({
                            title: 'SUCCESS',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK") {
                                    location.reload();
                                }
                            }
                        })
                    }
                    else {
                        $.msgBox({
                            title: 'FAILED',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK") {
                                    location.reload();
                                }
                            }
                        })
                    }
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }
    });

});
