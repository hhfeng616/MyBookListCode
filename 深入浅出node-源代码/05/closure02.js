var foo = function () {
  (function () {
    var local = "ć±éšćé";
  }());
  console.log(local);
};
foo();
