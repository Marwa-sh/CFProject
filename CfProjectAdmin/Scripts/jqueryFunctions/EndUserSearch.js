$(window).load(function () {
   
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
            if (!((event.keyCode >= 48 && event.keyCode <= 57) || (event.keyCode >= 96 && event.keyCode <= 105))) {
                event.preventDefault();
            }
        }
    });

    $('#search').on('click', function () {
        var urlSearch = "/EndUserReservation/searchNumbersReservation?start=0";
        var numbersList = [];
        $("#search-container").find('.number-id').each(function () {
            numbersList.push($(this).attr("id"));
        });
        var matchtype = "";
        $('input[name=numberByFilter]:checked').each(function () {
            matchtype = $(this).attr("value");            
        });
        var num = $("#Number").val();        
        var classefication = $("#classLable").val();
        var from = -1;
        var to = -1;
        var setting = $("#sysSettings").val();
        if (setting == 1)
        {
            from = $("#from").val();
            to = $("#to").val();
        }
        if (num == "" && classefication == "" && from <= 0 && to <= 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Please insert one parameter at least.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: urlSearch,
                data: { number: num, classif: classefication, priceFrom: from, priceTo: to, numberShown: numbersList.toString(), matchType: matchtype },
                type: "GET",
                dataType: "json",
                cache: false,
                async: true,
                success: function (data) {
                    if (data.status) {
                        $("#search-container").html('');
                        $(data.content).hide().appendTo($("#search-container")).fadeIn(1000);
                        if (data.message == "Next") {
                            $('div#next').show();
                            $("#prevbtn").hide('');
                            $("#nextbtn").show('');
                        }
                        else {
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
        }        
    });

    $(document).on('click', '#nextbtn', function (e) {
        var urlSearch = "/EndUserReservation/searchNumbersReservation?next=0";
        var numbersList = [];
        $("#search-container").find('.number-id').each(function () {
            numbersList.push($(this).attr("id"));
        });
        var matchtype = "";
        $('input[name=numberByFilter]:checked').each(function () {
            matchtype = $(this).attr("value");
        });
        var from = -1;
        var to = -1;
        var setting = $("#sysSettings").val();
        if (setting == 1) {
            from = $("#from").val();
            to = $("#to").val();
        }
        $('body').addClass('wait');
        $.ajax({
            url: urlSearch,
            data: { number: $("#Number").val(), classif: $("#classLable").val(), priceFrom: from, priceTo: to, numberShown: numbersList.toString(), matchType: matchtype },
            type: "GET",
            dataType: "json",
            cache: false,
            async: true,
            success: function (data) {
                if (data.status) {                   
                    if (data.message == "Next") {
                        $("#search-container").html('');
                        $(data.content).hide().appendTo($("#search-container")).fadeIn(1000);
                        $('div#next').show();
                        $("#nextbtn").show();
                        $("#prevbtn").show();
                    }
                    else {
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
        var urlSearch = "/EndUserReservation/searchNumbersReservation?prev=0";
        var numbersList = [];
        $("#search-container").find('.number-id').each(function () {
            numbersList.push($(this).attr("id"));
        });
        var matchtype = "";
        $('input[name=numberByFilter]:checked').each(function () {
            matchtype = $(this).attr("value");
        });
        var from = -1;
        var to = -1;
        var setting = $("#sysSettings").val();
        if (setting == 1) {
            from = $("#from").val();
            to = $("#to").val();
        }
        $('body').addClass('wait');
        $.ajax({
            url: urlSearch,
            data: { number: $("#Number").val(), classif: $("#classLable").val(), priceFrom: from, priceTo: to, numberShown: numbersList.toString(), matchType: matchtype },
            type: "GET",
            dataType: "json",
            cache: false,
            async: true,
            success: function (data) {
                if (data.status) {
                    $("#search-container").html('');
                    $(data.content).hide().appendTo($("#search-container")).fadeIn(1000);
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
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });

    });

});