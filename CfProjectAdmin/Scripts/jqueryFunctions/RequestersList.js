$(document).ready(function () {

    //$().loadMore({
    //    button: $("#load-more"),
    //    container: $("#requesters-container"),
    //    auto: false,
    //    url: "/Requester/?",
    //});


    //$('.sort_filter').sortt({
    //    button: $("#load-more"),
    //    container: $("#requesters-container"),
    //    url: "/Requester/?",
    //});


    $(document).on('click', '#sort_checkbox1', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-active-requester:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-active-requester:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#active-requesters-container tr").first().clone();
        $("#active-requesters-container").html("");
        $("#active-requesters-container").append(header);
        cloneCheckedRows.each(function () {
            $("#active-requesters-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#active-requesters-container").append($(this));
        });
    });

    $(document).on('click', '#sort_checkbox2', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-nonactive-requester:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-nonactive-requester:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#nonactive-requesters-container tr").first().clone();
        $("#nonactive-requesters-container").html("");
        $("#nonactive-requesters-container").append(header);
        cloneCheckedRows.each(function () {
            $("#nonactive-requesters-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#nonactive-requesters-container").append($(this));
        });
    });

    $(document).on('click', '#btnDeactiveRequesters', function (e) {
        var selectedrequesters = [];
        $("input[name='checkedActiveRequesters']:checked").each(function () {
            selectedrequesters.push(this.value);
        });        
        var count = selectedrequesters.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any requesters",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }        
        else {
            $.msgBox({
                title: 'Delete Requesters',
                content: 'Are You Sure you want to delete ' + count + ' requester(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Requester/deleteSelectedRequesters",
                            type: "GET",
                            data: { requesters: selectedrequesters.toString() },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success:
                                function (data) {
                                    if (data.status) {
                                        $.msgBox({
                                            title: 'success msg',
                                            content: count + data.message,
                                            opacity: 0.5,
                                            buttons: [{ value: "OK" }],
                                            success: function (result) {
                                                if (result == "OK")
                                                    location.reload();
                                            }
                                        })
                                    }
                                    else
                                        $.msgBox({
                                            title: 'WARNING',
                                            content: "Delete requester(s) failed.",
                                            opacity: 0.5,
                                            buttons: [{ value: "OK" }],
                                        })
                                },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    }
                }
            })
        }
    });

    $(document).on('click', '#btnActiveRequesters', function (e) {
        var selectedrequesters = [];
        $("input[name='checkedNonactiveRequesters']:checked").each(function () {
            selectedrequesters.push(this.value);
        });
        var count = selectedrequesters.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any requesters",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Active Requesters',
                content: 'Are You Sure you want to active ' + count + ' requester(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Requester/activeSelectedRequesters",
                            type: "GET",
                            data: { requesters: selectedrequesters.toString() },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success:
                                function (data) {
                                    if (data.status) {
                                        $.msgBox({
                                            title: 'success msg',
                                            content: count + data.message,
                                            opacity: 0.5,
                                            buttons: [{ value: "OK" }],
                                            success: function (result) {
                                                if (result == "OK")
                                                    location.reload();
                                            }
                                        })
                                    }
                                    else
                                        $.msgBox({
                                            title: 'WARNING',
                                            content: "Active requester(s) failed.",
                                            opacity: 0.5,
                                            buttons: [{ value: "OK" }],
                                        })
                                },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    }
                }
            })
        }
    });

});