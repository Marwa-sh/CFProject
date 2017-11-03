$(document).ready(function () {

    $('#cancelReservation').on('click', function () {
        $.msgBox({
            title: 'Aert',
            content: "Are you sure that you want to cancel this reservation?",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    var numbersList = [];
                    $("#reserved-container").find('.number-id').each(function () {
                        numbersList.push($(this).attr("id"));
                    });
                    if (numbersList.length == 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "You don't have any number in request",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                        })
                    }
                    else {
                        $.ajax({
                            url: "/CorporateReservation/cancelReservation",
                            data: { numbers: numbersList.toString() },
                            type: "GET",
                            dataType: "json",
                            cache: false,
                            async: true,
                            success: function (data) {
                                if (data.status) {
                                    $.msgBox({
                                        title: 'SUCCESS',
                                        content: data.message,
                                        type: "success",
                                        opacity: 0.5,
                                        buttons: [{ value: "OK" }],
                                        success: function (result) {
                                            if (result == "OK")
                                                location.href = "/CorporateReservation/MyReservation";
                                        }
                                    })

                                } else {
                                    $.msgBox({
                                        title: 'WARNING',
                                        content: data.message,
                                        opacity: 0.5,
                                        buttons: [{ value: "OK" }],
                                    })
                                }
                            },
                            error: function (data) {
                            }
                        });
                    }
                }
            }
        })
    });

});