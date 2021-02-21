SELECT x.id as "Treinamento#", p.id, p.nome, p.sobrenome, st.nome, st.Lotacao, e.DataHoraInicio as Inicio, e.DataHoraFim as Termino,
h.DataHoraInicio as inicio_intervalo, h.DataHoraFim as fim_intervalo
FROM pessoasalatreinamento x
left join pessoa p on (p.id = x.pessoaid)
left join salatreinamento st on (st.id = x.salatreinamentoid)
left join etapa e on (e.id = x.EtapaId)
left join horarioCafe h on (h.id = x.HorarioCafeId)
left join salaCafe s on (s.id = x.SalaCafeId);