var controller = function () {
  controller.prototype.submit = function submit() {
    console.log(this.model);
  }
}

addAngularState('register', '/register', 'Register', controller, '');