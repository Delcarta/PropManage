$(function () {

    Messenger.options = {
        extraClasses: 'messenger-fixed messenger-on-top  messenger-on-right',
        theme: 'flat',
        messageDefaults: {
            showCloseButton: true
        }
    }
    Messenger().post({
        message: 'Hey, how are you?<br>Welcome to Simply Manage Property Solutions - Alpha.<br> You are free to take a look around as long as you don\'t mind the dust.',
        type: 'success'
    });
});