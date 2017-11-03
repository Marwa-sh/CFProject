$(document).ready(function () {
    
    //$().loadMore({
    //    button: $("#load-more"),
    //    container: $("#groups-container"),
    //    auto: false,
    //    url: "/Group/?",
    //});
       

    //$('.sort_filter').sortt({
    //    button: $("#load-more"),
    //    container: $("#groups-container"),
    //    url: "/Group/?",
    //});

    
    $(document).on('click', '#sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-group:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-group:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#groups-container tr").first().clone();
        $("#groups-container").html("");
        $("#groups-container").append(header);
        cloneCheckedRows.each(function () {
            $("#groups-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#groups-container").append($(this));
        });
    });

    $(document).on('click', '#btnDeleteGroup', function (e) {
        var selectedGroups = [];
        $("input[name='checkedGroup']:checked").each(function () {
            selectedGroups.push(this.value);
        });
        var count = selectedGroups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any groups",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Delete Groups',
                content: 'Are You Sure you want to delete ' + count + ' group(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    $('body').addClass('wait');
                    if (result == "Yes") {
                        $.ajax({
                            url: "/Group/deleteSelectedGroups",
                            type: "GET",
                            data: { groups: selectedGroups.toString() },
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
                                            content: "Delete groups failed.",
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