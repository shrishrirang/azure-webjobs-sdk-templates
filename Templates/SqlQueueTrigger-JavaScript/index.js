module.exports = function (context, msg) {
    context.log('JavaScript queue trigger function processed work item', msg);
    context.done();
};
