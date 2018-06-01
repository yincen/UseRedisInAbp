var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('UsingRedisInAbp');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);