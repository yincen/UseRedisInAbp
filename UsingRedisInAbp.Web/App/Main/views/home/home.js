 (function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.cacheTest', function ($scope,service) {
            var vm = this;
            //Home logic...
            vm.article = {};
            vm.title = "";
            vm.id = 0;
            vm.createArticle = function() {
                service.createArticle({ title: vm.title }).success(function(result) {
                    abp.notify.success("文章创建成功");
                });
            };
            vm.getArticle = function() {
                service.getArticle({ id:vm.id}).success(function (result) {
                    vm.article = result;
                });
            };
        }
    ]);
})();