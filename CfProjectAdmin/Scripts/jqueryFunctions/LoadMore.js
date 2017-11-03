(function($) {
    $.fn.loadMore = function(options) {
        var settings = $.extend({
            container: $('body'),
            fadeInSpeed: 1000,
            auto: true,
            button: null,
            url: null,
            callback: null
        }, options);
        var ready = true; //Set the flag here
        if (settings.url) {
            settings.callback = function() {
                if (settings.button) {
                    settings.button.addClass('activate').text("");
                }
                var ajaxURL = settings.url;
                //check for sort                 
                $('.Sort').each(function () {
                    ajaxURL += 'sort=' + $(this).val() + "&";
              //      console.log(ajaxURL);
                })
                //var sort_value = $('.Sort').val();
                //if (sort_value > 0)
                //    ajaxURL += 'sort=' + sort_value;
                //ajaxURL += 'sort=' + sort_value + "&";
                    //ajaxURL += '&sort=' + $(this).attr("name");
                       
                    //ajaxURL += $(this).val();
                //   });


                //check for search
                var search_value = $('#search_value');
              //  console.log(ajaxURL);
                ajaxURL += (search_value.length > 0) ? search_value.val() + "&" : "";
           //     console.log(ajaxURL);

                //check for filters
                $('.filter_value').each(function () {
        //            console.log($(this).val());
                    ajaxURL += $(this).val()+"&";
               //     console.log(ajaxURL);
                });
                 

                

           //     console.log(ajaxURL);
                $.ajax({
                    type: "GET",
                    url: ajaxURL,
                    dataType: 'json',
                    cache: false,
                    async: true,
                    success: function(data) {
                        if (data.status) {
                            $(data.content).hide().appendTo(settings.container).fadeIn(settings.fadeInSpeed);
                            settings.button.text(data.message);
                            $(document).trigger("contentChanged");
                        } else {
                                settings.button.text(data.message);
                        }
                    },
                    error: function(data) {
       //                 console.log(data);
                    },
                    complete: function() {
                        if (settings.button) {
                            settings.button.removeClass('activate');
                        }
                        ready = true;
                    }
                });
            }; 
        }
        if (settings.button !== null) {
            settings.button.click(settings.callback);
        }

        $(window).scroll(function() {
            
            if(ready && $(window).scrollTop() > $(document).height() - $(window).height() -1)
            {
                ready = false;
                if (settings.auto ) {
                    if (settings.button)
                    {
                        settings.button.click();
                    }
                    else {
                        settings.callback();
                    }
                }
            }
        });
    };
}(jQuery));