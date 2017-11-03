$(document).ready(function () {

    $("#Number").keydown(function (event) {
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
            if (!((event.keyCode >= 48 && event.keyCode <= 57) || (event.keyCode >= 96 && event.keyCode <=105))) {
                event.preventDefault();
            }
        }
    });

    $(document).on('click', '#searchbtn', function (e) {
        var urlSearch = "/CorporateReservation/searchSeriesReservation?start=0";
        var numberCount = $("#numberCount").val();
        if (numberCount == "") {
            $.msgBox({
                title: 'WARNING',
                content: "Please enter count of numbers that you want to reserve it.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            var series = [];
            var num = $("#Number").val();
            var patern = $("#Pattern").val();
            var classefication = $("#classLable").val();
            var from = $("#from").val();            
            var to = $("#to").val();
            if (from == "" || to == "") {
                from = -1;
                to = -1;
            }
            $('body').addClass('wait');
            $.ajax({
                url: urlSearch,
                data: { number: num, pattern: patern, classif: classefication, priceFrom: from, priceTo: to, count: numberCount, tempSeries: series.toString() },
                type: "GET",
                dataType: "json",
                cache: false,
                async: true,
                success: function (data) {
                    if (data.status) {
                        $("#serie-container").html('');
                        $(data.content).hide().appendTo($("#serie-container")).fadeIn(1000);
                        if (data.message == "Next") {
                            $('div#next').show();
                            $("#nextbtn").show();
                            $("#prevbtn").hide();
                        }
                        else {
                            $('div#next').hide();
                        }
                        $(document).trigger("contentChanged");
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

    $(document).on('click', '#nextbtn', function (e) {
        var urlSearch = "/CorporateReservation/searchSeriesReservation";
        var numberCount = $("#numberCount").val();
        var num = $("#Number").val();
        var patern = $("#Pattern").val();
        var classefication = $("#classLable").val();
        var from = $("#from").val();
        var to = $("#to").val();
        if (from == "" || to == "") {
            from = -1;
            to = -1;
        }
        $('body').addClass('wait');
        $.ajax({
            url: urlSearch,
            data: { number: num, pattern: patern, classif: classefication, priceFrom: from, priceTo: to, count: numberCount, tempSeries : [] },
            type: "GET",
            dataType: "json",
            cache: false,
            async: true,
            success: function (data) {
                if (data.status) {                    
                    if (data.message == "Next") {
                        $("#serie-container").html('');
                        $(data.content).hide().appendTo($("#serie-container")).fadeIn(1000);
                        $('div#next').show();
                        $("#nextbtn").show();
                        $("#prevbtn").show();
                    }
                    else {
                        //$('div#next').hide();
                        $("#nextbtn").hide();
                    }
                    $(document).trigger("contentChanged");
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
    });

    $(document).on('click', '#prevbtn', function (e) {
        var urlSearch = "/CorporateReservation/prevSearchSeriesReservation";
        var numberCount = $("#numberCount").val();
        var num = $("#Number").val();
        var patern = $("#Pattern").val();
        var classefication = $("#classLable").val();
        var from = $("#from").val();
        var to = $("#to").val();
        if (from == "" || to == "") {
            from = -1;
            to = -1;
        }
        $('body').addClass('wait');
        $.ajax({
            url: urlSearch,
            data: { number: num, pattern: patern, classif: classefication, priceFrom: from, priceTo: to, count: numberCount, tempSeries: [] },
            type: "GET",
            dataType: "",            
            success: function (data) {                
                if (data.status) {
                    $("#serie-container").html('');
                    $(data.content).hide().appendTo($("#serie-container")).fadeIn(1000);
                    if (data.message == "Next") {
                        $('div#next').show();
                        $("#nextbtn").show();
                        $("#prevbtn").show();
                    }
                    else {
                        $("#nextbtn").show();
                        $("#prevbtn").hide();
                    }
                    $(document).trigger("contentChanged");
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
                $('div#next').hide();
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });
    });


});