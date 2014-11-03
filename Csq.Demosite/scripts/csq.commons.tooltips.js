/// <reference path="jquery-1.11.1.min.js" />
/// <reference path="csq.commoms.js" />

(
    function ($) {
        $.fn.tooltips = function (msg) {
            var position = {
                Left: String.format("{Left}px", { Left: this.offset().left + this.width() + 2 }),
                Top: String.format("{Top}px", { Top: this.offset().top })
            };
            $("#Tooltip").text(msg).css("left", position.Left).css("top", position.Top).css("position", "absolute").css("z-index", 9999).show();
            var me = $("#Tooltip");
            var timerID = window.setTimeout(function () {
                me.slideUp("fast", function () {
                    window.clearTimeout(timerID);
                    me.hide();
                    timerID = null;
                });
            }, 3000);
        }
    }
)(jQuery);