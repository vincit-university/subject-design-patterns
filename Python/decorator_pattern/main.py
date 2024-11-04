from cafe_adicional_de_acucar import CafeAdicionalDeAcucar
from cafe_adicional_de_leite import CafeAdicionalDeLeite
from cafe_simples import CafeSimples


cafe = CafeSimples()
print(f"{cafe.get_descricao()} Preço: {cafe.get_custo()}")

cafe = CafeAdicionalDeLeite(cafe)
print(f"{cafe.get_descricao()} Preço: {cafe.get_custo()}")

cafe = CafeAdicionalDeAcucar(cafe)
print(f"{cafe.get_descricao()} Preço: {cafe.get_custo()}")