$(document).ready(function () {

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
    $("#alternativeNumber").keydown(function (event) {
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

    $(document).on('change', '#selReason', function (e) {
        var reason = $("#selReason").val();
        if (reason == "CHANGE_NUMBER") {
            $('label#oldNumberLabel').show();
            $('div#oldNumber').show();
        }
        else {
            $('label#oldNumberLabel').hide();
            $('div#oldNumber').hide();
        }
    });
    $("#old_Number").keydown(function (event) {
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

    $(document).on('click', '.delete-choosed-number', function () {
        var numberId = $(this).closest('tr').attr("id");
        $(this).closest('tr').remove();
        var numbersList = [];
        $("#number-container").find('.number-id').each(function () {
            numbersList.push($(this).attr("id"));
        });
        if (numbersList.length == 0) {
            location.href = "/VIPReservation/NewReservation";
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: "/VIPReservation/ReleaseNumber",
                data: { numberID: numberId },
                type: "GET",
                dataType: "json",
                cache: false,
                async: true,
                success: function (data) {
                },
                error: function (data) {
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }        
    });


    $('#cancelbtn').on('click', function () {
        $.msgBox({
            title: 'WARNING',
            content: "Are you sure that you want to cancel the request?",
            opacity: 0.5,
            buttons: [{ value: "OK" }],
            success: function (result) {
                if (result == "OK")
                    location.href = "/VIPReservation/NewReservation";
            }
        })        
    });

    $('#confirmbtn').on('click', function () {
        var numbersList = [];
        $("#number-container").find('.number-id').each(function () {
            numbersList.push($(this).attr("id"));
        });

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
            var prof = $("#profession").val();
            if (prof == "")
                prof = null;
            var educ = $("#education").val();
            if (educ == "")
                educ = null;
            var birthDate = $("#monthID").val() + "-" + $("#dayID").val() + "-" + $("#yearID").val();
            if ($("#monthID").val() == 0 || $("#dayID").val() == 0 || $("#yearID").val() == 0)
                birthDate = null;
            var alterNum = $("#alternativeNumber").val();
            var remark = $("#remark").val();
            var reason = $("#selReason").val();
            var oldNum = "";
            if (reason == "CHANGE_NUMBER") {
                oldNum = $("#old_Number").val();                
            }
            if (oldNum == "" && reason == "CHANGE_NUMBER") {
                $.msgBox({
                    title: 'WARNING',
                    content: "Please insert an old number",
                    opacity: 0.5,
                    buttons: [{ value: "OK" }],
                })
            }
            else {
                $('body').addClass('wait');
                $.ajax({
                    url: "/VIPReservation/ReserveNumbers",
                    data: { numberIDs: numbersList.toString(), customerName: customerName, typeID: idType, idNumber: idNumber, contractNO: contactNum, prof: prof, educ: educ, birthDate: birthDate, alternativeNumber: alterNum, reason: reason, oldNumber: oldNum, remark: remark },
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
                                        location.href = "/VIPReservation/MyReservation";
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
        }
    });

    $(document).on('change', '#monthID', function (e) {
        $("#dayID").html('');
        var month = $("#monthID").val();
        var year = $("#yearID").val();
        var res = 1;
        var i = 1;
        if (month == "Jan" || month == "Mar" || month == "May" || month == "Jul" || month == "Aug" || month == "Oct" || month == "Dec") {
            while (i <= 31) {
                $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                i++;
            }
        }
        else if (month == "Apr" || month == "Jun" || month == "Sep" || month == "Nov") {
            while (i <= 30) {
                $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                i++;
            }
        }
        else {
            if (year != 0) {
                res = year % 4;
                if (res == 0) {
                    while (i <= 29) {
                        $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                        i++;
                    }
                }
                else {
                    while (i <= 28) {
                        $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                        i++;
                    }
                }
            }
            else {
                while (i <= 28) {
                    $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                    i++;
                }
            }
        }

    });

    $(document).on('change', '#yearID', function (e) {
        var month = $("#monthID").val();
        var year = $("#yearID").val();
        var res = year % 4;
        var i = 1;
        if (month == "Feb") {
            $("#dayID").html('');
            if (res == 0) {
                while (i <= 29) {
                    $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                    i++;
                }
            }
            else {
                while (i <= 28) {
                    $("#dayID").append('<option value=' + i + '>' + i + '</option>');
                    i++;
                }
            }
        }
    });

});