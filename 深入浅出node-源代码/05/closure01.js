var foo = function () {
  var local = "ć±éšćé";
  (function () {
    console.log(local);
  }());
};
foo();
