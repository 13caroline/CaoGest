<template>
    <div id = "direitos" class = "direitos">
        <Navbar :id="$route.params.id" />
        <Direitos :id="$route.params.id" />
        <v-btn
            v-scroll="onScroll"
            x-large
            v-show="fab"
            fab
            depressed
            fixed
            bottom
            right
            class = "ma-6"
            color="deep-orange lighten-4"
            @click="toTop"
        >
            <v-icon>keyboard_arrow_up</v-icon>
         </v-btn>   
        <Footer :id="$route.params.id" />
    </div>
</template>

<script>
import Navbar from '@/components/NavbarFooter/Navbar.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import Direitos from '@/components/Docs/Direitos.vue'
export default {
    name:"direitos", 
    props:['id'],
    data() {
        return {
            fab:false,
        }
    },
    components: {   Navbar, 
                    Footer,
                    Direitos },
    methods: {
        onScroll (e) {
            if (typeof window === 'undefined') return
            const top = window.pageYOffset ||   e.target.scrollTop || 0
            this.fab = top > 20
        },
        toTop () {
            this.$vuetify.goTo(0)
        },
    }
}
</script>