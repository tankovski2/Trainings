(function () {
    'use strict';

    var controllerId = 'editIssueController';

    angular.module('failtrackerApp').controller(controllerId,
        ['$scope', '$http', editIssueController]);

    function editIssueController($scope, $http) {

        $scope.editing = false;
        $scope.init = init;
        $scope.save = save;
        $scope.cancel = cancel;
        $scope.edit = edit;

        function init(issue) {
            $scope.originalIssue = angular.extend({}, issue);
            $scope.issue = issue;
        }

        function edit() {
            $scope.editing = true;
        }

        function save() {

            $http.post("/Issue/Edit", $scope.issue)
                .success(function (data) {
                    if (data.success !== true) {
                        alert("There was a problem saving to the server: " + data.errorMessage);
                        return;
                    }

                    $scope.originalIssue = angular.extend({}, $scope.issue);

                    $scope.editing = false;
                })
                .error(function() {
                    alert("There was a problem saving the issue.  Please try again.");
                });
        }

        function cancel() {
            angular.extend($scope.issue, $scope.originalIssue);
            $scope.editing = false;
        }
    }
})();
