<template>
    <Horario :id="$route.params.id" :id2="$route.params.id2"/>
</template>

<script>
// @ is an alias to /src
import Horario from '@/components/Admin/HorarioCanil.vue'
export default {
  name: 'HorarioCanil',
  components: {
    Horario
  }
}
</script>