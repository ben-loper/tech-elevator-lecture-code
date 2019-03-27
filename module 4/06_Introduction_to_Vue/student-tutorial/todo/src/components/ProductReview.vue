<template>
    <div class="main">
        <h2>Product Reviews for {{ name }}</h2>
        <p>{{ msg }}</p>
        <p class="description">{{ description }}</p>
    </div>
</template>

<script>
export default {
    name: 'product-review',
    props: {
        msg: String
    },
    data() {
        return {
            name: 'Cigar Parties for Dummies',
            description: 'Host and plan the perfect cigar party for all of your squirrelly friends.',
            mike: {
                name: 'Mike',
                age: 67
            }
        }
    },
    methods: {
        getMyStuff() {
            this.name = 'Brian';
        }
    },
    created() {
        this.getMyStuff();
    }
}
</script>

<style>
div {
  background: rgb(74,55,67);
}
</style>
