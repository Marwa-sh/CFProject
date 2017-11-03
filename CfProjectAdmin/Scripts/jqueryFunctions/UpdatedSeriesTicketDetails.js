$(document).ready(function () {
    var moveLeft = 20;
    var moveDown = 10;
    $(document).on('click', '#closeAndApprove', function () {
        var url = $(this).attr('action-url');
        showCloseAndApproveDialog(url);
    });
    $(document).on('click', '#closeAndReject', function () {
        showRemarkDialog($(this).attr('action-url'));
    });
    $(document).on('click', '#showRequestInformation', function () {
        showRequestInformationForm();
    });
    $(document).on('click', '#cancelRequest', function () {
        var url = $(this).attr('action-url');
        showCancelDialog(url);
    });

    $('[data-toggle="extend-confirmation"]').confirmation({
        container: 'body',
        onConfirm: function () {
            //ajax call
            $('body').addClass('wait');
            $.ajax({
                type: "POST",
                url: $(this).attr('ajax-url'),
                dataType: 'json',
                cache: false,
                async: true,
                success: function (data) {
                    if (data.Status && data.Url != null) {
                        location.href = data.Url;
                    }
                    if (!data.Status) {
                        $.msgBox({
                            title: 'Extend Reservation Request',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    }
                },
                error: function (data) {
                    //$.msg
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }
    });

    $('[data-toggle="delete-confirmation"]').confirmation({
        container: 'body',
        onConfirm: function () {
            //ajax call
            $('body').addClass('wait');
            $.ajax({
                type: "POST",
                url: $(this).attr('ajax-url'),
                dataType: 'json',
                cache: false,
                async: true,
                success: function (data) {
                    if (data.status) {
                        $.msgBox({
                            type:'success',
                            title: 'Release Series',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                        
                    }
                    if (!data.status) {
                        $.msgBox({
                            title: 'Release Series',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    }
                },
                error: function (data) {
                    //$.msg
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }
    });
    //related pools
    $('.relatedPools').click(null, function (e) {
        var seriesId = $(this).attr("seriesId");
        $.ajax({
            url: "/AxiosSeries/getRelatedPools",
            type: "GET",
            data: { seriesId: seriesId },
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
    $(document).on('contentChanged', function () {
        $('.relatedPools').click(null, function (e) {
            var seriesId = $(this).attr("seriesId");
            $.ajax({
                url: "/AxiosSeries/getRelatedPools",
                type: "GET",
                data: { seriesId: seriesId },
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

    });
    
});
function showRemarkDialog(url) {
    var button = {
        success: {
            label: "Close And Reject",
            className: "btn btn-primary",
            callback: function () {
                var remark = $("#remarkTextArea").val();
                if (remark.trim() == "") {
                    return false
                } else {
                    location.href = url + "&remarkTextArea=" + $("#remarkTextArea").val();
                }
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
        size: 'small',
        title: "Please Enter Remark",
        message: 'Remark :<br/> <textarea id="remarkTextArea" name = "remarkTextArea">' + $("#requestedSeries").val() + '</textarea><br/>',
        buttons: button
    });
}
function showCloseAndApproveDialog(url) {
    var button = {
        success: {
            label: "Close And Approve",
            className: "btn btn-primary",
            callback: function () {
                var remark = $("#remarkTextArea").val();
                if (remark.trim() == "") {
                    return false
                } else {
                    location.href = url + "&remark=" + remark;
                }
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
        size: 'small',
        title: "Please Enter Remark",
        message: 'Remark :<br/> <textarea id="remarkTextArea" name = "remarkTextArea">' + $("#requestedSeries").val() + '</textarea><br/>',
        buttons: button
    });
}
function showRemarkDialog(url) {
    var button = {
        success: {
            label: "Close And Reject",
            className: "btn btn-primary",
            callback: function () {
                var remark = $("#remarkTextArea").val();
                if (remark.trim() == "") {
                    return false
                } else {
                    location.href = url + "&remarkTextArea=" + $("#remarkTextArea").val();
                }
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
        size: 'small',
        title: "Please Enter Remark",
        message: 'Remark :<br/> <textarea id="remarkTextArea" name = "remarkTextArea">' + $("#requestedSeries").val() + '</textarea><br/>',
        buttons: button
    });
}
function showRequestInformationForm() {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                $("#form-container").find('.error').remove();
                var requesterGroup = $("#requesterGroup").val(); var requester = $("#requester").val();
                var idType = $("#idType").val(); var customerName = $("#customerName").val();
                var customerId = $("#customerId").val(); var contractNumber = $("#contractNumber").val();
                var requestReason = $("#requestReason").val();
                url = '/AxiosSeries/viewUpdatedTicketDetails?idType=' + idType + "&contractNumber=" + contractNumber
                        + "&customerId=" + customerId + "&customerName=" + customerName + "&requestReason=" + requestReason + "&saveReqInfo=true"
                        + "&requestId=" + $("#requestId").val();
                location.href = url;
                
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
        title: "Request Information",
        message: '<span id="form-container">'
                    + '<span class="col-xs-3 j-form-lable">Requester Group :</span> <span class="col-xs-9"><input type="text" readonly = "true" name="requesterGroup" id="requesterGroup" /></span> <br/>'
                    + '<span class="col-xs-3 j-form-lable">Requester :</span> <span class="col-xs-9"><input type="text" readonly = "true" name="requester" id="requester" /></span> <br/>'
                    + '<span class="col-xs-3 j-form-lable">Id Type :</span> <span class="col-xs-9 j-select-picker"><select name="idType" id="idType" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = " true" ></select></span><br />'
                    + '<span class="col-xs-3 j-form-lable">Customer Name :</span> <span class="col-xs-9"><input readonly = "true" class="form-control" type="text" name="customerName" id="customerName" /></span><br/>'
                    + '<span class="col-xs-3 j-form-lable">Customer ID :</span> <span class="col-xs-9"><input readonly = "true" class="form-control" type="text" name="customerId" id="customerId" /></span><br/>'
                    + '<span class="col-xs-3 j-form-lable">Contract Number :</span> <span class="col-xs-9" id="cn"><input readonly = "true" class="form-control" type="text" name="contractNumber" id="contractNumber" /></span><br/>'
                + '</span>'
                ,
        buttons: button
    });
    box.on("shown.bs.modal", function () {
        var requestInfo = JSON.parse($("#requestInfo").val());
        var idType = JSON.parse($("#idTypes").val());
        $("#requesterGroup").val(requestInfo.requesterGroup);
        $("#requester").val(requestInfo.requester);
        $("#contractNumber").val(requestInfo.contractNumber);
        $("#customerId").val(requestInfo.customerId);
        $("#customerName").val(requestInfo.customerName);
        
       
        $.each(idType, function (key, value) {
            $("#idType").append('<option value="' + value + '">' + value + '</option>');
        });
        $(".selectpicker").selectpicker();
    });
}
function showCancelDialog(url) {
    var button = {
        success: {
            label: "Ok",
            className: "btn btn-primary",
            callback: function () {
                location.href = url;
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
        size: 'small',
        title: "Cancel Request",
        message: 'Are you sure you to cancel this reservation request',
        buttons: button
    });
}