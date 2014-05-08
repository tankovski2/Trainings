(function () {
    'use strict';

    var serviceId = 'alerts';

    angular.module('buildMyOwnFrameworkApp').factory(serviceId, function () {
        return window.alerts;
    });

})();
