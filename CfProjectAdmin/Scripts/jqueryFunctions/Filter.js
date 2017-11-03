(function($) {
    $.fn.filterek = function(options) {
        var settings = $.extend({
            moreLBL: 'More',
            noMoreLBL: 'No More!',
            errorLBL: 'Try Again',
            container: $('body'),
            fadeInSpeed: 1000,
            button: null,
            url: null,
            filtersArray: null
        }, options);

        $(this).click(function() {
            if (!settings.url) {
                return;
            }
            settings.container.html('');
            if (settings.button) {
                settings.button.addClass('activate').text("");
            }
            $('body').addClass('wait');
            //check for search
            var search_value = $('#search_value');
            var ajaxURL = (search_value.length > 0) ? (settings.url + "&" + search_value.val() + "&") : settings.url;
           
            //check for sort 
            $('.Sort').each(function () {
                ajaxURL += 'sort=' + $(this).val() + "&";

            });

            var url_var = '';
            if (settings.filtersArray)
            {
                url_var = ajaxURL;
                $.each(settings.filtersArray, function (index, value) {
                  //  console.log($(this).attr("target"));
                    if ($('input[name=' + value.attr("name") + ']:checked').attr('target'))
                        url_var += value.attr("name") + '=' + $('input[name=' + value.attr("name") + ']:checked').attr('target') + '&';
                  //  console.log(url_var);
                });
                url_var += "start=0";
            }
            else
            {
           //     console.log($(this).attr("target"));
             //   console.log($(this).attr("name"));
                var filter_value = $(this).attr("target") ;
                var filter_name = $(this).attr("name");
               // console.log(filter_value);
                url_var = ajaxURL +  $(this).attr("name") + '=' + filter_value +'&'+ "start=0";               
                //  url_var = ajaxURL + "groupByFilter=" + filter_value + "start=0";                
             //   console.log("kkkkkkkkkkkkkk" + url_var);
            }
            //console.log(url_var);
            $.ajax({
                type: "GET",
                url: url_var,
                dataType: 'json',
                cache: false,
                async: true,
                success: function(data) {
                        //console.log(data);
                    if (settings.button) {
                        settings.button.text(data.message);
                    }
                    if (data.status) {
                        $(data.content).hide().appendTo(settings.container).fadeIn(settings.fadeInSpeed);
                        $(document).trigger("contentChanged");
                        $(document).trigger("filterChanged");

                    } else {
                        if (settings.button) {
                            settings.button.text(data.message);
                        }
                    }
                },
                error: function(data) {
                },
                complete: function(data) {
                    $('.filter_value').remove();
                    if (settings.filtersArray)
                    {

                        $.each(settings.filtersArray, function(index, value) {
                            if ($('input[name=' + value.attr("name") + ']:checked').attr('target')) {
                                $('body').append('<input type="hidden" value="' + value.attr("name") + '=' + $('input[name=' + value.attr("name") + ']:checked').attr('target') + '" class="filter_value"/> ');
                            }
                        });
                    }
                    else
                    {
                      //  $('body').append('<input type="hidden" value="filter=' + filter_value + '" class="filter_value"/>');
                        $('body').append('<input type="hidden" value="' + filter_name + '=' + filter_value + '" class="filter_value"/>'+'&');
                  //      console.log("pppppppppppppp"+filter_value);
                    }
                    if (settings.button) {
                        settings.button.removeClass('activate');
                    }
                    $('body').removeClass('wait');
                }
            });
        });
    };
}(jQuery));