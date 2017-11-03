(function ($) {
    $.fn.sortt = function (options) {
        var settings = $.extend({
            moreLBL: 'More',
            noMoreLBL: 'No More!',
            errorLBL: 'Try Again',
            container: $('body'),
            fadeInSpeed: 1000,
            button: null,
            url: null,            
        }, options);

        //   $(this).click(function () {            
        $(document).on('click', '.sort_filter', function (e) {
            e.preventDefault();
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
            console.log(ajaxURL);

            //check for filters
            $('.filter_value').each(function () {
                ajaxURL += $(this).val() + "&";
            });

            var url_var = '';
            var sort_value = $(this).attr('name');
            url_var = ajaxURL + 'sort=' + sort_value + '&start=0';
         //   console.log(url_var);
             
            $.ajax({
                type: "GET",
                url: url_var,
                dataType: 'json',
                cache: false,
                async: true,
                success: function (data) {
                 //   console.log(data);
                    if (settings.button) {
                        settings.button.text(data.message);
                    }
                    if (data.status) {
                        $(data.content).hide().appendTo(settings.container).fadeIn(settings.fadeInSpeed);
                        $(document).trigger("contentChanged");
                        $(document).trigger("sortChanged");
                        

                    } else {
                        if (settings.button) {
                            settings.button.text(data.message);
                        }
                    }
                },
                error: function (data) {
                },
                complete: function (data) {
                    $('.Sort').remove();

                    $('body').append('<input type="hidden" class="Sort" name ="sort_value" value="' + sort_value + '"/>&');                   
                    
                    if (settings.button) {
                        settings.button.removeClass('activate');
                    }
                    $('body').removeClass('wait');
                }
            });
            return false;
        });
    };
}(jQuery));