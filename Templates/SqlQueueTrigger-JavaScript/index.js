module.exports = function (context, msg) {
    context.log('## JavaScript SQL queue trigger function processed message : ', msg);
    context.done();
};
