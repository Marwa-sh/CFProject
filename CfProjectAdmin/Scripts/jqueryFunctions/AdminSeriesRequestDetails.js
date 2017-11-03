$(document).ready(function () {
    url = $('#sortUrl').val();
    //-------
    
    $(document).on('click', '.sort_filter', function (e) {
        $('body').addClass('wait');
        $.ajax({
            type: "POST",
            url: url+"&sort="+$(this).attr('name') + "&start=0",
            dataType: 'json',
            cache: false,
            async: true,
            success: function (data) {
                $('#numbers-container').html(data.content).hide().fadeIn();
            },
            error: function (data) {
                console.log(data);
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });
    });
    //related pools
    var moveLeft = 20;
    var moveDown = 10;
    $(document).on('click', '.relatedPools', function (e) {
        e.preventDefault();
        var numberId = $(this).attr("number_Id");
        $.ajax({
            url: "/AxiosSeries/getRelatedPools",
            type: "GET",
            data: { clickedNumber: numberId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                $('div#relatedPools_popUp').html('');
                $('div#relatedPools_popUp').show()
                    .css('top', e.pageY + moveDown)
                    .css('left', e.pageX + moveLeft)
                    .append('<table>' + data + '</table>')
                    .appendTo('body');
            },
            error: function (data) {
            }
        });
    });
    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });

    $(document).on('click', '#export', function () {
        $("#numbers-form").append('<input type = "hidden" name="Export" value="Export" />');
        $("#numbers-form").submit();
    });
    $(document).on('click', '#cancel-request', function () {
        $.msgBox({
            title: 'Cancel Request ',
            content: 'Are You Sure You Want To Cancel Request',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $("#numbers-form").append('<input type = "hidden" name="CancelRequest" value="CancelRequest" />');
                    $("#numbers-form").submit();
                }
            }
        });
    });
    $(document).on('click', '#releaseSeries', function () {
        $.msgBox({
            title: 'Release Series',
            content: 'Are You Sure You Want To Release Series',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $("#numbers-form").append('<input type = "hidden" name="ReleaseSeries" value="ReleaseSeries" />');
                    $("#numbers-form").submit();
                }
            }
        });
    });
    
    $(document).on('click', '#reserve', function () {
        $.msgBox({
            title: 'Reserve Series ',
            content: 'Are You Sure You Want To Reserve Numbers',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $("#numbers-form").append('<input type = "hidden" name="Reserve" value="Reserve" />');
                    $("#numbers-form").submit();
                }
            }
        });
    });
    $(document).on('click', '#editRequestInformation', function () {
        showEditInformationDialog($(this).attr('ajax-url'));
    });
});

function showEditInformationDialog(url) {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                var idType = $("#idTypeElem").val(); var customerName = $("#customerNameElem").val();
                var customerId = $("#customerIdElem").val(); var contractNumber = $("#contractNumberElem").val();
                var requestReason = $("#requestReasonElem").val(); var oldNumber = $("#oldNumberElem").val();
                var remark = $("#remarkElem").val();
                url = url + "&idType=" + idType + "&idNumber=" + customerId + "&customerName=" + customerName
                            + "&contractNumber=" + contractNumber + "&requestReason=" + requestReason
                            + "&oldNumber=" + oldNumber + "&remark=" + remark;
                $('body').addClass('wait');
                $.ajax({
                    type: "POST",
                    url: url,
                    dataType: 'json',
                    cache: false,
                    async: true,
                    success: function (data) {
                        if (data.status) {
                            showMessage(data.message);
                            location.reload();
                        } else {
                            showMessage(data.message);
                        }
                    },
                    error: function (data) {
                        console.log(data);
                    },
                    complete: function () {
                        $('body').removeClass('wait');
                    }
                });
            }
        },
        danger: {
            label: "Cancel",
            className: "btn btn-default",
            callback: function () {
                return true;
            }
        }
    };

    var box = bootbox.dialog({
        size: 'medium',
        title: "Fill Request Information",
        message: '<span id="form-container">'
                    + '<span class="col-xs-4">Id Type :</span> <span class="col-xs-8"><select id="idTypeElem" name="idType" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = "true" ></select></span><br />'
                    + '<span class="col-xs-4">Customer Name :</span> <span class="col-xs-8"><input class="form-control" type="text" name="customerName" id="customerNameElem" /></span><br/>'
                    + '<span class="col-xs-4">Customer ID :</span> <span class="col-xs-8"><input class="form-control" type="text" name="customerId" id="customerIdElem" /></span><br/>'
                    + '<span class="col-xs-4">Contract Number :</span> <span class="col-xs-8"><input class="form-control" type="text" name="contractNumber" id="contractNumberElem" /></span><br/>'
                    + '<span class="col-xs-4">Remark :</span> <span class="col-xs-8"><textarea class="form-control" name="remark" id="remarkElem" ></textarea></span><br/>'
                + '</span>'
                ,
        buttons: button
    });
    box.on("shown.bs.modal", function () {
        $('#oldNumContaier').hide();
        var idType = JSON.parse($("#idType").val());
        var requestInfo = JSON.parse($("#reqInfo").val());
        $.each(idType, function (key, value) {
            if (value.id == requestInfo.idType)
                $("#idTypeElem").append('<option value="' + value.id + '" selected="true">' + value.text + '</option>');
            else {
                $("#idTypeElem").append('<option value="' + value.id + '">' + value.text + '</option>');
            }
        });
        

        
        $('select[name=requestReason]').val(requestInfo.requestReason);
        $("#contractNumberElem").val(requestInfo.contractNumber);
        $("#customerIdElem").val(requestInfo.idNumber);
        $("#customerNameElem").val(requestInfo.customerName);
        
        $("#remarkElem").val(requestInfo.remark);

        $(".selectpicker").selectpicker();

    });
}
function showMessage(message) {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                return true;
            }
        }
    };

    var box = bootbox.dialog({
        size: 'medium',
        title: "Info",
        message: message,
        buttons: button
    });
}
