$(document).ready(function () {
    
    $(document).on('change', '#selGroup', function (e) {
        var urlmodel = "/Group/GetRequestersInGroup/";
        var group = $('#selGroup').val();
        if (group == 0)
        {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any group.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
                success: function (result) {
                    if (result == "OK") {
                        $("#requester-container").html('');
                        $('div#remove').hide();
                    }
                }
            })
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: urlmodel,
                data: { groupID: group },
                type: "GET",
                dataType: "json",
                success: function (data) {
                    if (data.status) {
                        $("#UpdatePanel1").html('');
                        $("#requester-container").html('');
                        $(data.content).hide().appendTo($("#requester-container")).fadeIn(500);
                        $('div#remove').show();
                    }
                    else {
                        $("#requester-container").html('');
                        $("#UpdatePanel1").html('<b>' + data.message + '<b>');
                        $('div#remove').hide();
                    }
                },
                error: function (data) {
                    
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }
    });

   


    $(document).on('click', '#btnRemove', function (e) {
        $.msgBox({
            title: 'Aert',
            content: "Are you sure that you want to remove that requesters?",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    var urlmodel = "/Group/RemoveRequesters/";
                    var selectedRequesters = [];
                    $('input[name=checkedRequesters]:checked').each(function () {
                        selectedRequesters.push($(this).attr("value"));
                    });
                    if (selectedRequesters.length == 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "You didn't select any requester to remove it.",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                        })
                    }
                    else {
                        $('body').addClass('wait');
                        $.ajax({
                            url: urlmodel,
                            data: { groupID: $('#selGroup').val(), requestersID: selectedRequesters.toString() },
                            type: "GET",
                            dataType: "json",
                            success: function (data) {
                                if (data.status) {
                                    $("#UpdatePanel1").html('');
                                    $("#requester-container").html('');
                                    $(data.content).hide().appendTo($("#requester-container")).fadeIn(500);
                                    $('div#remove').show();
                                }
                                else {
                                    $("#requester-container").html('');
                                    $("#UpdatePanel1").html('<b>' + data.message + '<b>');
                                    $('div#remove').hide();
                                }

                            },
                            error: function (data) {
                                
                            },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    }
                }
            }
        })
    });

});
