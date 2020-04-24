var contactForm = contactForm ||
{
    init: function () {
        this.listeners();
    },
    listeners: function () {
        $(document).on("click",
            ".contact-submit",
            function () {
                e.preventDefault();
                var form = $("#contact-form");
                form.submit();     
        });
    },
    showResult: function () {
        $(".outer-form").hide("slow");
        $(".form-results").show("slow");
    }
}