$(document).ready(function () {

    
    $(document).on('click', '#btnAdd', function (e) {
        var type = $("#groupType").val();
        var name = $("#groupName").val();
        var remark = $("#remark").val();
        if (type == "") {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any type for new requester group.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else if (name == "") {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't insert A name of new requester group.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: "/Group/addRequesterGroup",
                data: { typeOfgroup: type, groupName: name, remark: remark },
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
                                    location.href = "/Group/Index";
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
