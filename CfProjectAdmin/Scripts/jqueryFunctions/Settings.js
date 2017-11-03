$(document).ready(function () {
    if ($("#pools_settings_container").length > 0) {
        $().loadMore({
            button: $("#load-more"),
            container: $("#pools_settings_container"),
            auto: false,
            url: '/SettingsManagement/viewPoolsSettingsF?',
        });
    }
    if ($("#groups_settings_container").length > 0) {
        $().loadMore({
            button: $("#load-more"),
            container: $("#groups_settings_container"),
            auto: false,
            url: '/SettingsManagement/viewGroupSettingsF?',
        });
    }

    $('[data-toggle="datetimepicker"]').datetimepicker({
        format: 'MM/DD/YYYY',
        useCurrent: true,
        showClear: true,
        showClose: true,
        ignoreReadonly: true
    });
    $(document).on('change', "#isPublic", function () {
        if ($("#isPublic:checked").length > 0) {
            $("#auto-radio").attr('checked', 'checked');
            $("input[name=CancelingType]").attr("disabled", true);
            $('#maxAllowedReservationsContainer').show();
            $("#groups-selector").hide();
            $("#expireDuration").hide();
        } else {
            $("input[name=CancelingType]").attr("disabled", false);
            $('#maxAllowedReservationsContainer').hide();
            $("#groups-selector").show();
            $("#expireDuration").show();
        }
    });
    $(document).on('change', "input[name=CancelingType]", function () {
        if ($(this).val() == 'Auto') {
            $("#expireDuration").show();
        } else {
            $("#expireDuration").hide();
        }
    });
    $("#isPublic").trigger('change');
    $("#CancelingType").trigger('change');
   
});