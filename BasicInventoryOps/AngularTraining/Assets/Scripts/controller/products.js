angular
    .module('MainApp')
    .controller('productsController', productsController);

function productsController($scope) {
    $scope.products = [
        { name: 'Gas Range', type: 'Kitchen Appliance' },
        { name: 'LG Smart TV', type: 'Home Appliance' },
        { name: 'Sharp Washing Machine', type: 'Home Appliance' },
        { name: 'Microwave Oven', type: 'Kitchen Appliance' }
    ];
}