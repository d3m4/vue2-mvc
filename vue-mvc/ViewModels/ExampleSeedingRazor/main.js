const Vue = require("vue$");
const $ = require("jQuery");

const v = new Vue({
    el: '#app',
    data: {
        description: "",
        preLoadedData: window.preLoadedData,
        serverData: null
    },
    mounted: function () {
        const me = this;

        me.$data.serverData = window.preLoadedData;
    },
    methods: {
        loadData: function(id){
            const me = this;

            $.ajax({
                contentType: "application/json",  
                dataType: "json",
                url: window.ServerUrl + "/ExampleSeedingRazor/GetData",
                method: "GET",
                data: {id:id},
                success: function (response) {
                    me.$data.serverData = response;
                },
                error: function (err) { 
                    console.error(err); 
                }
            })
        }
    }
});