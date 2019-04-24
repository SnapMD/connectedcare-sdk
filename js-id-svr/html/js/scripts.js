let app = angular.module('snapApp', ['ngCookies']);

app.config(function($locationProvider) {
    $locationProvider.html5Mode({
      enabled: true,
      requireBase: false
    })
})

app.controller('snapCtrl', function($scope, $http, $cookies, $location) {
  $scope.req = {}
  $scope.opts = {}

  $scope.loadConfig = () => {
    $http.get('/api/hosts').then(function (response) {
      console.log('getHosts: success', response.data)
      $scope.hosts = response.data
      $scope.opts.host = $scope.hosts[0]
    }, function (response) {
      console.error('getHosts: error', response)
      $scope.appMessage = `getHosts failed: ${response.statusText}`
    });

    $http.get('/api/langs').then(function (response) {
      console.log('getLangs: success', response.data)
      $scope.langs = response.data
      $scope.opts.lang = $scope.langs[0]
    }, function (response) {
      console.error('getLangs: error', response)
      $scope.appMessage = `getLangs failed: ${response.statusText}`
    });

    $http.get('/api/fees').then(function (response) {
      console.log('getFees: success', response.data)
      $scope.fees = response.data
      $scope.opts.fee = $scope.fees[0]
    }, function (response) {
      console.error('getFees: error', response)
      $scope.appMessage = `getFees failed: ${response.statusText}`
    });

    $http.get('/api/roles').then(function (response) {
      console.log('getRoles: success', response.data)
      $scope.roles = response.data
      $scope.opts.role = $scope.roles[0]
    }, function (response) {
      console.error('getRoles: error', response)
      $scope.appMessage = `getRoles failed: ${response.statusText}`
    });
  }

  $scope.loadConfig()

  $scope.login = () => {
    let req = {
        method: 'POST',
        url: '/api/sso-sessions',
        data: {
          req: $scope.req,
          opts: $scope.opts
        },
        responseType: 'json'
    }
    $http(req).then(function (response) {
      console.log('login: success', response.data)
      let url = response.data.url
      if (url) {
        document.getElementById('modalMessage').innerHTML = `redirecting to ${$scope.opts.host.name} ...`
        document.getElementById('id02').style.display='block'
        setTimeout(url => {
          location.href = url
        }, 2500, url)
      }
    }, function (response) {
      console.error('login: error', response)
      $scope.appMessage = `login failed: ${response.statusText}`
    });
  }
});

app.filter('orderObjectBy', function() {
  return function(items, field, reverse) {
    var filtered = [];
    angular.forEach(items, function(item) {
      filtered.push(item);
    });
    filtered.sort(function (a, b) {
      return (a[field] > b[field] ? 1 : -1);
    });
    if(reverse) filtered.reverse();
    return filtered;
  };
});

function getUrlParameter(name) {
    name = name.replace(/[\[]/, '\\[').replace(/[\]]/, '\\]');
    var regex = new RegExp('[\\?&]' + name + '=([^&#]*)');
    var results = regex.exec(location.search);
    return results === null ? '' : decodeURIComponent(results[1].replace(/\+/g, ' '));
}

// Get the modal
var modal = document.getElementById('id01');

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}
