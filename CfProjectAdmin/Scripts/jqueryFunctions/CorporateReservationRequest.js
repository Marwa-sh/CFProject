$(document).ready(function () {
    var serie_id = $("#serie_id").val();
    url = "/CorporateReservation/MyReservationF?"
    
    $("#idNumber").keydown(function (event) {
        // Allow: backspace, delete, tab, escape and enter
        if ($.inArray(event.keyCode, [46, 8, 9, 27, 13, 110]) !== -1 ||
            // Allow: Ctrl+A, Command+A
        (event.keyCode === 65 && (event.ctrlKey === true || event.metaKey === true)) ||
            // Allow: home, end, left, right, down, up
        (event.keyCode >= 35 && event.keyCode <= 40)) {
            // let it happen, don't do anything

        }
        else {
            // Ensure that it is a number and stop the keypress
            if (event.keyCode < 48 || event.keyCode > 57) {
                event.preventDefault();
            }
        }
    });
    $("#contractNumber").keydown(function (event) {
        // Allow: backspace, delete, tab, escape and enter
        if ($.inArray(event.keyCode, [46, 8, 9, 27, 13, 110]) !== -1 ||
            // Allow: Ctrl+A, Command+A
        (event.keyCode === 65 && (event.ctrlKey === true || event.metaKey === true)) ||
            // Allow: home, end, left, right, down, up
        (event.keyCode >= 35 && event.keyCode <= 40)) {
            // let it happen, don't do anything

        }
        else {
            // Ensure that it is a number and stop the keypress
            if (event.keyCode < 48 || event.keyCode > 57) {
                event.preventDefault();
            }
        }
    });
    
    $('#cancelbtn').on('click', function () {
        $.msgBox({
            title: 'WARNING',
            content: "Are you sure that you want to cancel the request?",
            opacity: 0.5,
            buttons: [{ value: "OK" }],
            success: function (result) {
                if (result == "OK") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/CorporateReservation/CancelRequest",
                        data: { serieID: serie_id },
                        type: "GET",
                        dataType: "json",
                        cache: false,
                        async: true,
                        success: function (data) {
                            if (data.status) {
                                location.href = "/CorporateReservation/NewReservationSearch";
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
        })        
    });

    $('#confirmbtn').on('click', function () {
        
        var idType = $("#IDType").val();
        var idNumber = $("#idNumber").val();
        var customerName = $("#customerName").val();
        if (idType == 0 || idNumber == "" || customerName == "") {
            $.msgBox({
                title: 'WARNING',
                content: "Please insert data in mandatory fields.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            var contactNum = $("#contractNumber").val();
            if (contactNum == "")
                contactNum = null;            
            var remark = $("#remark").val();
            $('body').addClass('wait');
            $.ajax({
                url: "/CorporateReservation/ReserveNumbers",
                data: { serieID: serie_id, customerName: customerName, typeID: idType, idNumber: idNumber, contractNO: contactNum, remark: remark },
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
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });            
        }
    });
   
});