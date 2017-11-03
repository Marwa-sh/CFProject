$(window).load(function () {
    var sysUser = $("#sysUserFilter").val();
    var reqGroup = $("#requesterGroupFilter").val();
    var req = $("#reqFilter").val();
    var customerName = $("#customerNameFilter").val();
    var customerId = $("#customerIdFilter").val();
    var contractNumber = $("#contractNumberFilter").val();
    var eventRef = $("#eventRef").val();
    var timeLogged = $("#timeLoggedFilter").val();
    var resolutionDue = $("#resolutionDueFilter").val();
    var statues = $("#statusFilter").val();

    if ($("#serviceOfferingName").val() == "AXIOS_SERIES") {
        url = '/AxiosSeries/getTicketListF?sysUser=' + sysUser + "&requesterGroup=" + reqGroup + "&customerId=" + customerId + "&contractNumber=" + contractNumber
                    + "&req=" + req + "&customerName=" + customerName + "&timeLogged=" + timeLogged + "&resolutionDue=" + resolutionDue + "&statues=" + statues + "&eventRef=" + eventRef + "&"
    }
    if ($("#serviceOfferingName").val() == "AXIOS_VIP") {
        url = '/AxiosReservation/getTicketListF?sysUser=' + sysUser + "&requesterGroup=" + reqGroup + "&customerId=" + customerId + "&contractNumber=" + contractNumber
                    + "&req=" + req + "&customerName=" + customerName + "&timeLogged=" + timeLogged + "&resolutionDue=" + resolutionDue + "&statues=" + statues + "&eventRef=" + eventRef + "&"
    }
    
    $().loadMore({
        button: $("#load-more"),
        container: $("#tickets-container"),
        auto: false,
        url: url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#tickets-container"),
        url: url,
    });
    $(document).on('click', '#searchAndFilter', function () {
        showSearchFilterDialog();
    });
});
function showSearchFilterDialog() {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                var sysUser = '';
                var reqGroup = '';
                var req = '';
                var statues = '';
                if ($("#SYSUsers option:selected").val())
                     sysUser = $("#SYSUsers option:selected").val();
                if ($("#requesterGroupSelect option:selected").val())
                     reqGroup = $("#requesterGroupSelect option:selected").val();
                if ($("#requesterSelect option:selected").val())
                    req = $("#requesterSelect option:selected").val();
                if ($("#statues option:selected").val()) {
                    statues = $("#statues").val();
                }
                var customerName = $("#customerName").val();
                var customerId = $("#customerId").val();
                var contractNumber = $("#contractNumber").val();
                var ticketId = $("#ticketId").val();
                var timeLogged = $("#timeLogged").val();
                var resolutionDue = $("#resolutionDue").val();
                var statues = $("#statues").val();
                var eventRef = $("#eventRef").val();
                if ($("#serviceOfferingName").val() == "AXIOS_SERIES") {
                    url = '/AxiosSeries/getTicketList?sysUser=' + sysUser + "&requesterGroup=" + reqGroup + "&customerId=" + customerId + "&contractNumber=" + contractNumber
                    + "&req=" + req + "&customerName=" + customerName + "&timeLogged=" + timeLogged + "&resolutionDue=" + resolutionDue + "&statues=" + statues + "&eventRef=" + eventRef + "&Start=0";
                }
                if ($("#serviceOfferingName").val() == "AXIOS_VIP") {
                    url = '/AxiosReservation/getTicketList?sysUser=' + sysUser + "&requesterGroup=" + reqGroup + "&customerId=" + customerId + "&contractNumber=" + contractNumber
                     + "&req=" + req + "&customerName=" + customerName + "&timeLogged=" + timeLogged + "&resolutionDue=" + resolutionDue + "&statues=" + statues + "&eventRef=" + eventRef + "&Start=0";
                }
                
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
        title: "Search And Filters",
        message: '' 
                    + '<span class="col-xs-3">Status :</span> <span class="col-xs-9"><select name="statues" id="statues" type="select" class = "selectpicker show-tick show-menu-arrow" multiple = "multiple" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "2" data_actions_box = " true" data_selected_text_format = "count > 2" data_count_selected_text = "{0} Items selected" ></select></span> <br/>'
                    + '<span class="col-xs-3">SYSUser :</span><span class="col-xs-9"> <select name="SYSUsers" id="SYSUsers" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = " true"></select></span> <br/>'
                    + '<span class="col-xs-3">Requester Group :</span> <span class="col-xs-9"><select name="requesterGroupSelect" id="requesterGroupSelect" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = " true" ></select></span> <br/>'
                    + '<span class="col-xs-3">Requester :</span> <span class="col-xs-9"><select id="requesterSelect" name="requesterSelect" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = "true" ></select></span> <br/>'
                    + '<span class="col-xs-3">Customer Name :</span> <span class="col-xs-9"><div class="input-group"><input class="form-control" type="text" name="customerName" id="customerName" /></div></span><br/>'
                    + '<span class="col-xs-3">Customer ID :</span> <span class="col-xs-9"><div class="input-group"><input class="form-control" type="text" name="customerId" id="customerId" /></div></span><br/>'
                    + '<span class="col-xs-3">Contract Number :</span> <span class="col-xs-9"><div class="input-group"><input class="form-control" type="text" name="contractNumber" id="contractNumber" /></div></span><br/>'
                    + '<span class="col-xs-3">Event Ref :</span> <span class="col-xs-9"><div class="input-group"><input class="form-control" type="text" name="eventRef" id="eventRef" /></div></span><br/>'
                    + '<span class="col-xs-3">Time Logged :</span> <span class="col-xs-9"><div class="input-group date"><input class="form-control" data-toggle="datetimepicker" type="text" name="timeLogged" id="timeLogged" readonly ></input></div></span><br/>'
                    + '<span class="col-xs-3">Resolution Date :</span> <span class="col-xs-9"><div class="input-group date"><input class="form-control" data-toggle="datetimepicker" type="text" name="resolutionDue" id="resolutionDue" readonly ></input></div></span><br/>'
                + ''
                ,
        buttons: button
    });
    box.on("shown.bs.modal", function () {
        var users = JSON.parse($("#users").val());
        var requesters = JSON.parse($("#requesters").val());
        var groups = JSON.parse($("#groups").val());
        $("#SYSUsers").append('<option value="' + "" + '">' + "" + '</option>');
        $.each(users, function (key, value) {
            $("#SYSUsers").append('<option value="' + value.REQUESTER_ID + '">' + value.REQUESTER_NAME + '</option>');
        });
        $.each(groups, function (key, value) {
            $("#requesterGroupSelect").append('<option value="' + value + '">' + value + '</option>');
        });
        $.each(requesters, function (key, value) {
            $("#requesterSelect").append('<option value="' + value + '">' + value + '</option>');
        });
        //fill statues
        $("#statues").append('<option value="">' + "" + '</option>');
        $("#statues").append('<option value="ASSIGNED">' + "ASSIGNED" + '</option>');
        $("#statues").append('<option value="VALIDATED">' + "VALIDATED" + '</option>');
        $("#statues").append('<option value="CLOSED_AND_REJECTED">' + "CLOSED AND REJECTED" + '</option>');
        $("#statues").append('<option value="PENDING">' + "PENDING" + '</option>');
        $("#statues").append('<option value="CLOSED_AND_APPROVED">' + "CLOSED AND APPROVED" + '</option>');
        $("#statues").append('<option value="UPDATED">' + "UPDATED" + '</option>');
        $(".selectpicker").selectpicker();
        $('[data-toggle="datetimepicker"]').datetimepicker({
            format: 'MM/DD/YYYY',
            useCurrent: true,
            showClear: true,
            showClose: true,
            ignoreReadonly: true//,
            //            showTodayButton: true
        });

    });
}