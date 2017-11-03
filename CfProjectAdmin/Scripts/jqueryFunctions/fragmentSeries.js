$(document).ready(function () {
    var seriesId = $("input[name=seriesId]").val();
    var tableData = [];
    var releasedNumbers = [];
    var range = $("input[name=seriesRange]").val();
    var sorceSeriesFirstContent = $("input[name=sorceSeriesFirstContent]").val();
    var sourceSeriesLastContent = $("input[name=sourceSeriesLastContent]").val();
    var sourceSeriesNumbersCount = $("input[name=sourceSeriesNumbersCount]").val();
    var minSeriesLength = $("input[name=minSeriesLength]").val();
    var item = "";

    $("#fragment").on('click', function (e) {
        e.preventDefault();
        $('body').addClass('wait');



     //   var seriesRange = $("input[name=seriesRange]").val();
        //var sorceSeriesFirstContent = $("input[name=sorceSeriesFirstContent]").val();
       // var sourceSeriesNumbersCount = $("input[name=sourceSeriesNumbersCount]").val();
       // var minSeriesLength = $("input[name=minSeriesLength]").val();

        var startIndex = $("#startIndex").val();
        var endIndex = $("#endIndex").val();

        if (Number(startIndex) >= Number(sourceSeriesNumbersCount)) {
            $.msgBox({
                title: 'WARNING',
                content: "You have made all possible sub series",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
                success: function (result) {
                    if (result == "OK") {
                        $('body').removeClass('wait');
                        return true;
                    }
                }
            });
        } else {
            if (Number(endIndex) > Number(sourceSeriesNumbersCount)) {
                $.msgBox({
                    title: 'WARNING',
                    content: "series length must be smaller than fragmented series'length (" + sourceSeriesNumbersCount + ")",
                    opacity: 0.5,
                    buttons: [{ value: "OK" }],
                    success: function (result) {                        
                        if (result == "OK") {
                            $("#endIndex").val('');
                            $('body').removeClass('wait');
                            return true;
                        }
                    }
                });
            } else {
                var newSubSeriesLength = Number(endIndex) - Number(startIndex);
                var newSubSeriesFirstContent = Number(sorceSeriesFirstContent) + Number(startIndex);
                var newSubSeriesLastContent = Number(newSubSeriesFirstContent) + Number(newSubSeriesLength) - 1;

                var subSeriesLengthAllowFragment = true;
                if (newSubSeriesLength < minSeriesLength)
                    subSeriesLengthAllowFragment = false;

                if (!subSeriesLengthAllowFragment) {
                    $.msgBox({
                        title: 'WARNING',
                        content: "series should has " + minSeriesLength + " numbers atleast",
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {
                            if (result == "OK") {
                                $('body').removeClass('wait');
                                return true;
                            }
                        }
                    });
                }
                else {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/Series/getFragmentedSeriesRow",
                        type: "GET",
                        data: { startIndex: startIndex, endIndex: endIndex, newSubSeriesFirstContent: newSubSeriesFirstContent, newSubSeriesLastContent: newSubSeriesLastContent, newSubSeriesLength: newSubSeriesLength, seriesRange: range },
                        dataType: "json",
                        traditional: true,
                        cache: false,
                        async: true,
                        success: function (data) {
                            if (data.error) {
                                $("#table-container").append(data.seriesRow);
                            }
                            else {

                                $("#startIndex").val(Number(data.newSeriesEndIndex));
                                $("#endIndex").val('');

                                $('.hiddenInput').remove();
                                $("#table-container").append(data.seriesRow);
                                $('body').removeClass('wait');

                            }
                        },
                        complete: function () {
                            $('body').removeClass('wait');
                        }
                    });
                }
            }
        }
    });


    $(document).on('click', '#removeSeriesRow', function (e) {
        e.preventDefault();              

        var removedStartIndex = $(this).attr('removedStartIndex');

        $("#startIndex").val(removedStartIndex);
        $("#endIndex").html('');

        $('.hiddenInput').remove();       
       
        var parent = $(this).closest('tr');
        allNextSiblings = parent.nextAll().remove();
        $(this).closest("tr").remove();
    });

    $("#AddToNMS").on('click', function (e) {
        e.preventDefault();
        
        tableData = [];
        releasedNumbers = [];
        item = "";
            $('#myTable > tbody  > tr').each(function () {
                item = "";

                var FirstContent = $(this).find('#FirstContent').attr('FirstContent');
                var LastContent = $(this).find('#LastContent').attr('LastContent');
              
                var Classification = $(this).find('#Classification').attr('Classification');
            
                if (typeof FirstContent != "undefined") {
                    item = range + '-' + FirstContent + '-' + LastContent + '-' + Classification ;
                    tableData.push(item);
                }
            });
            if (tableData.length == 0) {
                $('body').removeClass('wait');
                $.msgBox({
                    title: 'WARNING',
                    content: "you didn't make any sub series",
                    opacity: 0.5,
                    buttons: [{ value: "OK" }],
                    success: function (result) {
                        if (result == "OK") {
                            return true;
                        }
                    }
                });
            } else {
                var startIndex = $("#startIndex").val();
                var sourceSeriesNumbersCount = $("input[name=sourceSeriesNumbersCount]").val();
                var minSeriesLength = $("input[name=minSeriesLength]").val();
                var sorceSeriesFirstContent = $("input[name=sorceSeriesFirstContent]").val();
                if (Number(startIndex) < Number(sourceSeriesNumbersCount)) {
                    if (Number(sourceSeriesNumbersCount) - Number(startIndex) >= Number(minSeriesLength)) {                        
                        var newSubSeriesFirstContent = Number(sorceSeriesFirstContent) + Number(startIndex);
                        var newSubSeriesLastContent = sourceSeriesLastContent;
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Series/getUpperClassification",
                            type: "POST",
                            data: { firstContent: newSubSeriesFirstContent, lastContent: newSubSeriesLastContent },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success: function (newClassification) {
                                item = range + '-' + newSubSeriesFirstContent + '-' + newSubSeriesLastContent + '-' + newClassification;
                                tableData.push(item);
                                $.ajax({
                                    url: "/Series/AddFragmentedSeriesToNMS",
                                    type: "POST",
                                    data: { seriesId: seriesId, tableData: tableData, releasedNumbers: releasedNumbers },
                                    dataType: "json",
                                    traditional: true,
                                    cache: false,
                                    async: true,
                                    success: function (data) {
                                        $('body').removeClass('wait');
                                        $.msgBox({
                                            title: 'success',
                                            content: data,
                                            type: "success",
                                            opacity: 0.5,
                                            buttons: [{ value: "OK" }],
                                            success: function (result) {
                                                if (result == "OK") {
                                                    location.href = "/Series/seriesList"
                                                }
                                            }
                                        });
                                    }

                                });
                            },
                            error: function (data){
                                console.log(data);
                            },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    } else {
                        for (var i = Number(startIndex) ; i < Number(sourceSeriesNumbersCount); i++) {
                            var num = Number(sorceSeriesFirstContent) + i;
                            releasedNumbers.push(num);
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/Series/AddFragmentedSeriesToNMS",
                                type: "POST",
                                data: { seriesId: seriesId, tableData: tableData, releasedNumbers: releasedNumbers },
                                dataType: "json",
                                traditional: true,
                                cache: false,
                                async: true,
                                success: function (data) {
                                    $('body').removeClass('wait');
                                    $.msgBox({
                                        title: 'success',
                                        content: data,
                                        type: "success",
                                        opacity: 0.5,
                                        buttons: [{ value: "OK" }],
                                        success: function (result) {
                                            if (result == "OK") {
                                                location.href = "/Series/seriesList"
                                            }
                                        }
                                    });
                                },
                                complete: function () {
                                    $('body').removeClass('wait');
                                }
                            });
                        }
                    }
                } else {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/Series/AddFragmentedSeriesToNMS",
                        type: "POST",
                        data: { seriesId: seriesId, tableData: tableData, releasedNumbers: releasedNumbers },
                        dataType: "json",
                        traditional: true,
                        cache: false,
                        async: true,
                        success: function (data) {
                            $('body').removeClass('wait');
                            $.msgBox({
                                title: 'success',
                                content: data,
                                type: "success",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                                success: function (result) {
                                    if (result == "OK") {
                                        location.href = "/Series/seriesList"
                                    }
                                }
                            });
                        },
                        complete: function () {
                            $('body').removeClass('wait');
                        }
                    });
                }
                
            }
        
    });
    $("#Cancel").on('click', function (e) {
        e.preventDefault();
        location.href = "/Series/SeriesNumbers?seriesId=" + seriesId;
    });
})