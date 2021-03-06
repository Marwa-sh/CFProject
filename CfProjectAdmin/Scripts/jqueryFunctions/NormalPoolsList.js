﻿$(window).load(function () {
    filters = [$("input[name=statusFilter]"), $("input[name=approvalCycleFilter]")];
    $().loadMore({
        button: $("#load-more"),
        container: $("#pools-container"),
        auto: false,
        url: "/Pools/getNormalPoolsListF?",
    });
    $("input[name=statusFilter]").filterek({
        button: $("#load-more"),
        container: $("#pools-container"),
        url: "/Pools/getNormalPoolsListF?",
        filtersArray: filters
    });
    $("input[name=approvalCycleFilter]").filterek({
        button: $("#load-more"),
        container: $("#pools-container"),
        url: "/Pools/getNormalPoolsListF?",
        filtersArray: filters
    });
    $("#data-search").search({
        button: $("#load-more"),
        container: $("#pools-container"),
        url: "/Pools/getNormalPoolsListF?"
    });
    $("#exportPools").click(function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        var status = $("input[name=statusFilter]:checked").attr('target');
        var approvalCycle = $("input[name=approvalCycleFilter]:checked").attr('target');
        var search = $("#data-search").find('[type=text]').val();
        $("#myForm").append("<input type = 'hidden' name='status' value='" + status + "' class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='approvalCycle' value='" + approvalCycle + "' class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='search' value='" + search + "' class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='poolType' value= 'NORMAL' class='hiddenInput'/>");
        $("#myForm").submit();
    });
});