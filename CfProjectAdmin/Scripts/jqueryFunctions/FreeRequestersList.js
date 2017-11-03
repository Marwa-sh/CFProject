$(document).ready(function () {

    //$().loadMore({
    //    button: $("#load-more"),
    //    container: $("#requesters-container"),
    //    auto: false,
    //    url: "/Group/?",
    //});


    //$('.sort_filter').sortt({
    //    button: $("#load-more"),
    //    container: $("#requesters-container"),
    //    url: "/Group/?",
    //});


    $(document).on('click', '#sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-requester:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-requester:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#requesters-container tr").first().clone();
        $("#requesters-container").html("");
        $("#requesters-container").append(header);
        cloneCheckedRows.each(function () {
            $("#requesters-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#requesters-container").append($(this));
        });
    });

    $(document).on('click', '#btnAdd', function (e) {
        var selectedrequesters = [];
        $("input[name='checkedRequester']:checked").each(function () {
            selectedrequesters.push(this.value);
        });
        var selectedGroup = $("#selGroup").val();
        var count = selectedrequesters.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any requesters",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else if (selectedGroup == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select group",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Add Requesters to Group',
                content: 'Are You Sure you want to add ' + count + ' requester(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Group/addSelectedRequestersToGroup",
                            type: "GET",
                            data: { group: selectedGroup, requesters: selectedrequesters.toString() },
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
                                            content: "Add requester(s) to group failed.",
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