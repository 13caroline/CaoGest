<template>
    <div id = "requestkennel" class = "Request Kennel">
        <Navbar :id="$route.params.id"/>
        <v-card flat height = "100"></v-card>
        <PedidosAdocao :id="$route.params.id" :id2="$route.params.id2"/>
        <Footer :id="$route.params.id"/>
    </div>
</template> 

<script>
import Navbar from '@/components/NavbarFooter/NavbarKennel.vue'
import Footer from '@/components/NavbarFooter/FooterKennel.vue'
import PedidosAdocao from '@/components/PedidosAdocaoCanil.vue'
  export default {
        components: { Navbar, 
                      Footer, 
                      PedidosAdocao, 
        },
  }
</script>     