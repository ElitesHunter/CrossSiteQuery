/// <reference path="jquery-1.11.1.min.js" />
/// <reference path="csq.commoms.js" />

(
function ($) {
    $.fn.preloader = function () {
        /// <summary>
        /// 加载条插件。
        /// </summary>

        var me = this;
        var timerID = null;
        var loaderWidth = 5;

        this.beginLoading = function () {
            var $loader = this.find("div.preloader");
            $loader.css("width", "5px");
            loaderWidth = 5;
            this.show();
            timerID = window.setInterval(function () {
                loaderWidth += 5;
                if (loaderWidth < me.width() - 5) {
                    $loader.css("width", String.format("{Width}px", { Width: loaderWidth }));
                }
                else {
                    window.clearInterval(timerID);
                    timerID = null;
                }
            }, 10);

            return this;
        }

        this.stopLoading = function () {
            this.hide();
            if (timerID != null && timerID != undefined) {
                window.clearInterval(timerID);
                timerID = null;
            }
            return this;
        }

        return this;
    }
}
)(jQuery)